import { NgModule } from '@angular/core';
import { HomeComponent } from './pages/home/home.component';
import { ContainersModule } from 'src/components/containers/containers.module';
import { CommonModule } from '@angular/common';
import { SlickCarouselModule } from 'ngx-slick-carousel';
import { PipeModule } from 'src/pipes/env/pipe.module';
import { DetalheProdutoComponent } from './pages/produto/detalhe-produto.component';
import { RouterModule } from '@angular/router';
import { ConsultaLojasComponent } from './pages/consulta-lojas/consulta-lojas.component';
import { ProductModule } from 'src/components/product/product.module';
import { CarrinhoComponent } from './pages/carrinho/carrinho.component';
import { MaterialModule } from 'src/components/material/material.module';
import { FormsModule } from '@angular/forms';
import { DirectiveModule } from 'src/directives/directive.module';
import { BrowserModule } from '@angular/platform-browser';

@NgModule({
    declarations: [HomeComponent, DetalheProdutoComponent, ConsultaLojasComponent, CarrinhoComponent],
    exports: [HomeComponent, DetalheProdutoComponent, ConsultaLojasComponent, CarrinhoComponent],
    imports: [CommonModule, BrowserModule, ContainersModule, SlickCarouselModule, PipeModule, RouterModule, ProductModule, MaterialModule, FormsModule, DirectiveModule]
})
export class NavigationModule {

}