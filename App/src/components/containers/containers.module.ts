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
import { PracaService } from 'src/services/praca.service';
import { CestaTopoComponent } from './header/cesta-topo/cesta-topo.component';
import { DirectiveModule } from 'src/directives/directive.module';
import { DepartamentoService } from 'src/services/departamento.service';
import { HttpClientModule } from '@angular/common/http';
import { ContextService } from 'src/services/storage/context.service';
import { LoginTopoComponent } from './header/login-topo/login-topo.component';
import { LoginService } from 'src/services/login.service';
import { ClienteService } from 'src/services/cliente.service';
import { BsDropdownModule } from 'ngx-bootstrap';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
    providers: [PedidoService, 
        ImageUrlPipe, 
        PracaService, 
        DepartamentoService,
        LoginService, 
        ClienteService],
    exports: [ContainerComponent, 
        SliderComponent, 
        CarouselMarcasComponent, 
        CheckoutContainerComponent],
    declarations: [HeaderComponent, 
        CestaTopoComponent, 
        ContainerComponent, 
        MenuComponent, 
        SliderComponent, 
        FooterComponent,
        LoginTopoComponent, 
        CheckoutHeaderComponent, 
        CheckoutContainerComponent, 
        CarouselMarcasComponent],
    imports: [PipeModule, 
        BrowserModule, 
        HttpClientModule,
        CommonModule, 
        SlickCarouselModule, 
        RouterModule, 
        DirectiveModule]
})
export class ContainersModule {

}