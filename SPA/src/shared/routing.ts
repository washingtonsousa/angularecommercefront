import { HomeComponent } from 'src/navigation/pages/home/home.component';
import { DetalheProdutoComponent } from 'src/navigation/pages/produto/detalhe-produto.component';
import { ConsultaLojasComponent } from 'src/navigation/pages/consulta-lojas/consulta-lojas.component';
import { CarrinhoComponent } from 'src/navigation/pages/carrinho/carrinho.component';

export const appRoutes = [

{
    path: '',  component: HomeComponent,
},
{
    path: 'produto/:produto/:sku', component: DetalheProdutoComponent
},
{
    path: 'consulta-lojas', component: ConsultaLojasComponent
},
{
    path: 'carrinho', component: CarrinhoComponent
}

];