# Farmácia Mais Próxima

# SPA - Single Page Application

## Server Side Rendering - Modo de Produção com SEO

### *Requisitos*:

 1. Node.js 12+
 2. Windows x64
 3. IIS 7 ou 8
 4. Module IISNODE
 5. Module Rewrite

### Passo 1

Verifique o arquivo ***server.ts*** na raiz do projeto,  este arquivo se refere ao servidor da plataforma *node.js* pré configurado pelo Angular para executar a engine de renderização no back end do Angular.


####  Contante "distFolder"  

    const  distFolder = join(__dirname, 'dist/SPA');

 Caminho do diretório de compilação do projeto, recomendado alterar o padrão do Angular obtido pelo processo para a global *__dirname* (atualmente já feito), a mesma deve ser obedecida caso copie os arquivos para o servidor em produção, Exemplo:
 
Se atualmente os arquivos estão em dist/SPA então no servidor deve seguir do mesmo padrão, apenas o conteúdo da pasta com sufixo ***-server*** pode ser colocado na raiz ou em subpastas desde que  url rewrite seja devidamente configurado para redirecionar as *REQUESTS* para ele, para auxilio neste processo são disponibilizados arquivos *web.config* na pasta config na raiz do projeto com exemplos de configuração para **iisnode**.

####  Constante "baseHref"

    const  baseHref= "/";

No presente momento o Angular Universal SSR **não** suporta renderização com ***baseHref*** apontado para sub diretórios. Logo presumimos que será publicado na raiz do web site, ou seja, mantenha apontando para o valor ***"/"*** combinado? =)

### Passo 2

Certifique-se de que todos os pré requisitos estão sendo cumpridos.

Execute o comando de compilação:

    npm run build:ssr

Caso queira executar algum teste execute o comando abaixo, talvez seja necessário copiar a pasta *SPA* para dentro da pasta *SAP-server* para que funcione.

    npm run serve:ssr


### Passo 3

 - Certifique-se de ter o iisnode e o module rewrite instalados no IIS e
   todas as especificações de ambas aplicações terem sido respeitadas.
   
   
 - Copie os arquivos da pasta *dist* para a pasta de publicação do seu  
   site. Copie o arquivo ***web.config*** com a configuração de rewrite 
   pronta contida na pasta config na raiz do projeto, certifique-se de  
   que esteja com o nome ***web.config***, pode ser que o arquivo antes 
   de ser copiado esteja com nome diferente.
 - Certifique-se de que toda a estrutura respeita a estrutura configurada no arquivo server.ts e de que o module rewrite esteja configurado corretamente para redirecionar as REQUESTS para o arquivo main.js, este arquivo pode ficar em qualquer pasta (o recomendado e que fique na raíz do projeto), mas os arquivos da aplicação devem respeitar a estrutura original configurada na constante ***distFolder*** e o handler do iisnode esteja apontando para o caminho do arquivo ***main.js***

## Agora é só testar!

# Observações:

Preste bastante atenção antes de publicar no arquivo de ambiente ***enviroments/enviroment.ts*** que pertence ao Angular, a variável de url de servidor de imagens precisa apontar para o servidor correto que irá prover as imagens que provavelmente é do backoffice e após certifique-se de que o module rewrite esteja permitindo que requests para /backoffice sejam ignoradas para que este diretório funcione.

ATENÇÃO DESENVOLVEDORES

Não criem rotas na aplicação que afetem a utilização do **backoffice**, este é um nome PROIBIDO dentro da cadeia de rotas e esta regra precisa ser respeitada para que a aplicação funcione corretamente

# Gerado Pelo Angular CLI - Use um tradutor se precisar =)

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 8.3.23.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory. Use the `--prod` flag for a production build.

## Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

## Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via [Protractor](http://www.protractortest.org/).

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI README](https://github.com/angular/angular-cli/blob/master/README.md).
