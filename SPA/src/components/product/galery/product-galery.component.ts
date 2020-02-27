import { Component, Input, OnInit, ViewChild, ElementRef, AfterViewInit } from '@angular/core';
import * as $ from "jquery";
import { ProdutoImagemModel } from 'src/shared/models/produto-imagem.model';

@Component({
    selector: 'product-galery',
    templateUrl: 'product-galery.component.html',
    styleUrls: ["product-galery.scss"]
})
export class ProductGaleryComponent implements AfterViewInit {

       @Input() public currentImageInBox: ProdutoImagemModel;
       public translateXAmount: number = 0;
       private maxNavRoller: number = 0;
       @ViewChild("galeryNavRoller", {read: ElementRef, static: false})   galeryNavRoller?: ElementRef<any>;
       @Input() public Imagens: ProdutoImagemModel[] = [];
 
       productNavLeft() {
        if(this.translateXAmount < 0) {
        this.translateXAmount += 120;
        }
       }

       productNavRight() {
        if( this.translateXAmount > this.maxNavRoller  || this.maxNavRoller >- -120 ) {
            this.translateXAmount -= 120;
        }

       }

       ngAfterViewInit() {
        this.maxNavRoller =   0 - ($(this.galeryNavRoller.nativeElement).width() - (120 * 3));
       }

}