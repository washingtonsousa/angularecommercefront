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
import { FormsModule } from '@angular/forms';
import { DirectiveModule } from 'src/directives/directive.module';
import { BrowserModule } from '@angular/platform-browser';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { ProdutoService } from 'src/services/produto.service';
import { TabsModule } from 'ngx-bootstrap';
import { CheckoutComponent } from './pages/checkout/checkout.component';

@NgModule({
    providers: [ProdutoService],
    declarations: [HomeComponent, DetalheProdutoComponent, CarrinhoComponent, CheckoutComponent],
    exports: [HomeComponent, DetalheProdutoComponent, CarrinhoComponent, CheckoutComponent],
    imports: [CommonModule, BrowserModule, ContainersModule, TabsModule, TooltipModule, SlickCarouselModule, PipeModule, RouterModule, ProductModule, MaterialModule, FormsModule, DirectiveModule]
})
export class NavigationModule {

}