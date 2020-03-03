import 'zone.js/dist/zone-node';
import { ngExpressEngine } from '@nguniversal/express-engine';
import * as express from 'express';
import { join } from 'path';
import { AppServerModule } from './src/main.server';
import { existsSync } from 'fs';

const baseHref= "/"; // Para controlar a base do aplicativo, no momento não funciona em subdiretório e precisa ser especificada também na linha de comando da compilação

// Criação do App
export function app() {
  const server = express();
  const distFolder = join(__dirname, 'dist/SPA');
  const indexHtml = existsSync(join(distFolder, 'index.original.html')) ? 'index.original.html' : 'index';

  // Engine do angular universal que renderiza as páginas no backend via node
  server.engine('html', ngExpressEngine({
    bootstrap: AppServerModule,
  }));

  server.set('view engine', 'html');
  server.set('views', distFolder);

  // Serve arquivos estáticos no navegador
  server.get('*.*', express.static(distFolder, {
    maxAge: '1y'
  }));

  // Todas as rotas do Angular utilizando a engine com o base Href
  server.get('*', (req, res) => {
    res.render(indexHtml, { req, providers: [{ provide: baseHref, useValue: req.baseUrl }] });
  });

  return server;
}

function run() {

  // Porta de execução do node Express
  const port = process.env.PORT || 4000; 

  // Start up the Node server
  const server = app();
  server.listen(port, () => {
    console.log(`Node Express sendo executado na URL http://localhost:${port}`);
  });

}

// Configurações do Web Pack, replaces de execução do require para _webpack_require
declare const __non_webpack_require__: NodeRequire;
const mainModule = __non_webpack_require__.main;
const moduleFilename = mainModule && mainModule.filename || '';
if (moduleFilename === __filename || moduleFilename.includes('iisnode')) {
  run();
}

export * from './src/main.server';
