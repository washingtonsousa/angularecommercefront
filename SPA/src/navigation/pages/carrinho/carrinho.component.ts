import {Component, ViewChild, ElementRef, OnInit} from "@angular/core";
import { PedidoService } from 'src/services/pedido.service';
import { PedidoModel } from 'src/shared/models/pedido.model';
import { RemoverCestaDirective } from 'src/directives/functions/remover-cesta.directive';


@Component({
    selector: 'carrinho',
    templateUrl: 'carrinho.component.html'
})
export class CarrinhoComponent implements OnInit{

    public CEP: String = "";
    private Pedido?: PedidoModel;

    constructor(private _pedidoService: PedidoService) {

    }

    public get cepOk(): boolean {
        return this.CEP.length == 8;
    }
 
    public Lojas: any[] = [{

        Logo: "unifabra_logo.png"

    }, {

        Logo: "vfarma.png"

    }, {

        Logo: "logo-50.png"

    }];

    ngOnInit() {
          this.init();
    }

    init() {
        this._pedidoService.GetCurrentPedido().subscribe((Pedido: PedidoModel) => {
            this.Pedido = Pedido;
        });
    }


}