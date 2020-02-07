import { Component } from '@angular/core';
import * as jQuery from 'jquery';

@Component({
    selector: 'carousel-marcas',
    templateUrl: 'carousel-marcas.component.html',
    styleUrls: ["carousel-marca.scss"]
})
export class CarouselMarcasComponent {
    marcas = [
        {Arquivo: "/backoffice/uploads/Marca/logo-bayer.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/logo-johson-&-johson-.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/logo-nivea.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/logo-unilever.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/ache.png"},
        {Arquivo: "/backoffice/uploads/Marca/peg.png"},
        {Arquivo: "/backoffice/uploads/Marca/dove.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/logo-vult.jpg"},
      ];


      slideConfig = {
      "slidesToShow": 12, 
      "slidesToScroll": 1, 
      "nextArrow":"<a class='nav-btn next-slide'> <i class='fa fa-chevron-right'> </i>  </a>",
      "prevArrow":"<a class='nav-btn prev-slide'> <i class='fa fa-chevron-left'> </i> </a>",
      "autoplay": true,
      "infinite": true,
      "autoplaySpeed": 2000,
      responsive: [
        {
          breakpoint: 1024,
          settings: {
            slidesToShow: 4,
            slidesToScroll: 1,
            infinite: true,
            dots: true
          }
        },
        {
          breakpoint: 600,
          settings: {
            slidesToShow: 4,
            slidesToScroll: 1
          }
        },
        {
          breakpoint: 480,
          settings: {
            slidesToShow: 4,
            slidesToScroll: 1
          }
        }
        // You can unslick at a given breakpoint now by adding:
        // settings: "unslick"
        // instead of a settings object
      ]
    };
}