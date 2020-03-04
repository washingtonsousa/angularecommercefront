import { Component, ViewChild, ElementRef, HostListener, OnInit } from '@angular/core';
import * as $  from 'jquery';
import { DepartamentoService } from 'src/services/departamento.service';
import { DepartamentoModel } from 'src/shared/models/departamento.model';
import {ImageTypesPaths} from "src/shared/enums/image-type-paths";


@Component({
    selector: 'menu',
    templateUrl: 'menu.component.html',
})
export class MenuComponent implements OnInit {

            @ViewChild("navMobile", {static:false})   navMobile?: ElementRef<any>;
            Departamentos: DepartamentoModel[] = [];
            DepartamentosMenu: DepartamentoModel[] = [];
            ImageTypesPaths = ImageTypesPaths;

            constructor(private eRef: ElementRef, private _departamentoService:DepartamentoService) {
            }

            hideMobile() {
                $(this.navMobile.nativeElement).addClass("hide-menu");
            }

            showMobile() {
                $(this.navMobile.nativeElement).addClass("hide-menu");
            }

            toggleMobile() {
                $(this.navMobile.nativeElement).toggleClass("hide-menu");
            }

            @HostListener("window:click", ["$event"])
            clickOutside(event: any) {  
                
                    let isNavToggle = $(event.target).data("role") === "nav-mobile-toggle";

                    if(!this.navMobile.nativeElement.contains(event.target) && !isNavToggle)
                    this.hideMobile();
        
            }


            ngOnInit() {
                    this._departamentoService.GetMenuDepartamentos().subscribe((_result: DepartamentoModel[]) => {

                        this.Departamentos = _result;
                        this.DepartamentosMenu = this.Departamentos.slice(0, 4);

                    }, (err) => {


                    })
            }
}