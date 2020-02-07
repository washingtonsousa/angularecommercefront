import { Component, Input, ElementRef, AfterViewInit, ViewChild } from '@angular/core';
import * as $ from "jquery";

@Component({
    selector: '[product-card-carousel]',
    templateUrl: 'product-card-carousel.component.html',
    styleUrls: ["product-card-carousel.scss"]
})
export class ProductCardCarouselComponent implements AfterViewInit {

   @Input() public Produtos: any[] = [];
   public translateXAmount: number = 0;
   private maxNavRoller: number = 0;
   @ViewChild("NavRoller", {read: ElementRef, static: true})   NavRoller?: ElementRef<any>;
    @Input() public Titulo: String = "Destaques";

    constructor(private eRef: ElementRef){

    }

   productNavLeft() {
        if(this.translateXAmount < 0) {
        this.translateXAmount += 120;
        }
       }

       productNavRight() {
        if( this.translateXAmount > this.maxNavRoller) {
            this.translateXAmount -= 120;
        }

    }


    ngAfterViewInit() {

   
            $(this.eRef.nativeElement).addClass("overflow-hidden");
  
            this.maxNavRoller =   0 - ($(this.NavRoller.nativeElement).width() - (120 * 3));


    }
}