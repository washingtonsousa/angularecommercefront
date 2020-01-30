import { Component } from '@angular/core';

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
        {Arquivo: "/backoffice/uploads/Marca/logo-bayer.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/logo-johson-&-johson-.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/logo-nivea.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/logo-unilever.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/logo-bayer.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/logo-johson-&-johson-.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/logo-nivea.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/logo-unilever.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/logo-bayer.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/logo-johson-&-johson-.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/logo-nivea.jpg"},
        {Arquivo: "/backoffice/uploads/Marca/logo-unilever.jpg"}
      ];


      slideConfig = {
      "slidesToShow": 12, 
      "slidesToScroll": 1, 
      "nextArrow":"<a class='nav-btn next-slide'> <i class='fa fa-chevron-right'> </i>  </a>",
      "prevArrow":"<a class='nav-btn prev-slide'> <i class='fa fa-chevron-left'> </i> </a>",
      "autoplay": true,
      "infinite": false,
      "autoplaySpeed": 2000,
    };
}