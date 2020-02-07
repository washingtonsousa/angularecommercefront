import { Component } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';


@Component({
    selector: 'slider',
    templateUrl: 'slider.component.html'
})
export class SliderComponent {

        private Banners: any[] = [{
             Arquivo: "/backoffice/uploads/banner/Pharmaton-1200c400.jpg",
             Fundo : 
            "/backoffice/uploads/banner/Fundo/Pharmaton-1903x400-preco.jpg"},
            {
                Arquivo: "/backoffice/uploads/banner/Pharmaton-1200c400.jpg",
                Fundo : 
               "/backoffice/uploads/banner/Fundo/Pharmaton-1903x400-preco.jpg"}
            ];

}