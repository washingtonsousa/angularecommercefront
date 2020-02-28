import { Component, OnInit, ViewChildren, QueryList, ElementRef, AfterViewInit } from '@angular/core';
import * as jQuery from 'jquery';

@Component({
    selector: 'carousel-marcas',
    templateUrl: 'carousel-marcas.component.html',
    styleUrls: ["carousel-marca.scss"]
})
export class CarouselMarcasComponent implements AfterViewInit {

    @ViewChildren("carouselItem") carouselItems : QueryList<ElementRef>;

    Marcas = [
        {Arquivo: "/backoffice/uploads/Marca/logo-bayer.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/logo-johson-&-johson-.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/logo-nivea.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/logo-unilever.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/ache.png"},
        {Arquivo: "/backoffice/uploads/Marca/peg.png"},
        {Arquivo: "/backoffice/uploads/Marca/dove.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/logo-vult.jpg"},
      ];

    CarouselItemsGroup : any[] = [];
    ThumbNumber: number = 6;

    buildCarousel() {

      let GroupIndex = 0;
      let GroupLength =  Math.ceil(this.Marcas.length / this.ThumbNumber) == 1 ? 1 : (Math.ceil(this.Marcas.length / this.ThumbNumber) - 1);
      let GroupCount = 0;
      
      for(let i = 0; i <= GroupLength; i++) {
        this.CarouselItemsGroup.push([]);
      }

      for(let i =0; i < this.Marcas.length; i++) {

                this.CarouselItemsGroup[GroupIndex].push(this.Marcas[i]);
                GroupCount ++;

                if(GroupCount == this.ThumbNumber) {
                    GroupIndex++;
                    GroupCount = 0;
                }

      }

      this.carouselItems.changes.subscribe(data => {

        data._results.forEach(item => {

          let Percentage = 100 / this.ThumbNumber;
          jQuery(item.nativeElement).css("width", Percentage+"%");

        });
      })

    }

    ngAfterViewInit() {
          this.buildCarousel();
    }
}