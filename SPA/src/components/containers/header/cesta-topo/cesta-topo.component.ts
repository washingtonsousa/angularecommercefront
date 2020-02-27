import {Component, Input, ChangeDetectorRef, OnChanges, ViewChild, ElementRef, HostListener} from "@angular/core";
import { PedidoModel } from 'src/shared/models/pedido.model';
import * as $ from "jquery";
import { PracaModel } from 'src/shared/models/praca.model';
@Component({
 selector: "cesta-topo",
 templateUrl: "cesta-topo.component.html"
})
export class CestaTopoComponent implements OnChanges {
    
    @Input() Pedido: PedidoModel;
    @Input() Loja: PracaModel = null;
    @ViewChild("cestaItemsBox", {static: false}) cestaItemsBox: ElementRef;

    constructor(private cdRef: ChangeDetectorRef, private eRef: ElementRef) {
    }

    @HostListener("mouseover")
    openCesta() {

        $(this.cestaItemsBox.nativeElement).addClass("open");

    }

    @HostListener("window:click", ["$event"])
    clickOutside(event: any) {

            if(!this.eRef.nativeElement.contains(event.target))
            this.closeCesta();

    }

    @HostListener("mouseout")
    closeCesta() {

        $(this.cestaItemsBox.nativeElement).removeClass("open");

    }

    ngOnChanges() {
        this.cdRef.detectChanges();
    }
}