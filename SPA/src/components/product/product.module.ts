import { NgModule } from '@angular/core';
import { ProductCardComponent } from './card/product-card.component';
import { ProductCardCarouselComponent } from './carousel/product-card-carousel.component';
import { RouterModule } from '@angular/router';
import { PipeModule } from 'src/pipes/env/pipe.module';
import { CommonModule } from '@angular/common';
import { TooltipModule } from 'ngx-bootstrap/tooltip';


@NgModule({
    imports: [RouterModule, PipeModule, CommonModule, TooltipModule],
    exports: [ProductCardCarouselComponent, ProductCardComponent],
    declarations: [ProductCardCarouselComponent, ProductCardComponent]
})
export class ProductModule {

}