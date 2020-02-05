import { HomeComponent } from 'src/navigation/pages/home/home.component';
import { DetalheProdutoComponent } from 'src/navigation/pages/produto/detalhe-produto.component';
import { CarrinhoComponent } from 'src/navigation/pages/carrinho/carrinho.component';
import { CheckoutComponent } from 'src/navigation/pages/checkout/checkout.component';

export const appRoutes = [

{
    path: '',  component: HomeComponent,
},
{
    path: 'produto/:produto/:sku', component: DetalheProdutoComponent
},
{
    path: 'carrinho', component: CarrinhoComponent
},
{

    path: 'checkout', component: CheckoutComponent

}

];