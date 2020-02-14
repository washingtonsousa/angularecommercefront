import { NgModule } from '@angular/core';
import { HomeComponent } from './pages/home/home.component';
import { ContainersModule } from 'src/components/containers/containers.module';
import { CommonModule } from '@angular/common';
import { SlickCarouselModule } from 'ngx-slick-carousel';
import { PipeModule } from 'src/pipes/env/pipe.module';
import { DetalheProdutoComponent } from './pages/produto/detalhe-produto.component';
import { RouterModule } from '@angular/router';
import { ProductModule } from 'src/components/product/product.module';
import { CarrinhoComponent } from './pages/carrinho/carrinho.component';
import { MaterialModule } from 'src/components/material/material.module';
import { DirectiveModule } from 'src/directives/directive.module';
import { BrowserModule } from '@angular/platform-browser';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { ProdutoService } from 'src/services/produto.service';
import { TabsModule } from 'ngx-bootstrap';
import { CheckoutComponent } from './pages/checkout/checkout.component';
import { ConfirmacaoComponent } from './pages/confirmacao/confirmacao.component';
import { FormComponentsModule } from 'src/components/forms/form-components.module';
import { FormsModule } from '@angular/forms';

@NgModule({
    providers: [ProdutoService],
    declarations: [HomeComponent, DetalheProdutoComponent, CarrinhoComponent, CheckoutComponent, ConfirmacaoComponent],
    exports: [HomeComponent, DetalheProdutoComponent, CarrinhoComponent, CheckoutComponent, ConfirmacaoComponent],
    imports: [CommonModule, BrowserModule, FormComponentsModule, FormsModule,
        ContainersModule, 
        TabsModule, TooltipModule, SlickCarouselModule, PipeModule, 
        RouterModule, ProductModule, MaterialModule, 
        DirectiveModule]
})
export class NavigationModule {}