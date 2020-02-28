import { NgModule } from '@angular/core';
import { ProductCardComponent } from './card/product-card.component';
import { ProductCardCarouselComponent } from './carousel/product-card-carousel.component';
import { RouterModule } from '@angular/router';
import { PipeModule } from 'src/pipes/env/pipe.module';
import { CommonModule } from '@angular/common';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { ProductGaleryComponent } from './galery/product-galery.component';
import { BrowserAnimationsModule} from "@angular/platform-browser/animations";
import { DirectiveModule } from 'src/directives/directive.module';


@NgModule({
    imports: [RouterModule, PipeModule, CommonModule, TooltipModule, BrowserAnimationsModule, DirectiveModule, BrowserAnimationsModule],
    exports: [ProductCardCarouselComponent, ProductCardComponent, ProductGaleryComponent],
    declarations: [ProductCardCarouselComponent, ProductCardComponent, ProductGaleryComponent]
})
export class ProductModule {

}