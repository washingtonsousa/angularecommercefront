import { NgModule } from '@angular/core';
import { HeaderComponent } from './header/header.component';
import { ContainerComponent } from './container.component';
import { SliderComponent } from '../slider/slider.component';
import { FooterComponent } from './footer/footer.component';
import { PipeModule } from 'src/pipes/env/pipe.module';
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';
import { MenuComponent } from './header/menu/menu.component';
import { SlickCarouselModule } from 'ngx-slick-carousel';
import { RouterModule } from '@angular/router';
import { CarouselMarcasComponent } from './header/marcas/carousel-marcas.component';
import { PedidoService } from 'src/services/pedido.service';
import { CheckoutContainerComponent } from './checkout-container.component';
import { CheckoutHeaderComponent } from './header/checkout-header/checkout-header.component';
import { ImageUrlPipe } from 'src/pipes/env/image-url.pipe';

@NgModule({
    providers: [PedidoService, ImageUrlPipe],
    exports: [ContainerComponent, SliderComponent, CarouselMarcasComponent, CheckoutContainerComponent],
    declarations: [HeaderComponent, ContainerComponent, MenuComponent, SliderComponent, FooterComponent, CheckoutHeaderComponent, CheckoutContainerComponent, CarouselMarcasComponent],
    imports: [PipeModule, BrowserModule, CommonModule, SlickCarouselModule, RouterModule]
})
export class ContainersModule {

}