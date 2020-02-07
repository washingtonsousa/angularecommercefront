import { Component, ViewChild, OnInit, HostListener } from '@angular/core';
import { MenuComponent } from './menu/menu.component';
import { PedidoService } from 'src/services/pedido.service';
import { PedidoModel } from 'src/shared/models/pedido.model';
import { CestaProdutoService } from 'src/services/emitters/cesta-produto-emitter.service';

@Component({
    selector: 'main-header',
    templateUrl: 'header.component.html'
})
export class HeaderComponent implements OnInit {
            
    @ViewChild("Menu", {static: false}) MenuComp?: MenuComponent;
    public Pedido: PedidoModel;
    private TopHeaderClass: String = "";

    get QuantidadeProdutoCarrrinho() : number {

                if(this.Pedido == undefined)
                return 0;

                let quantidade = 0;

                for(let Produto of this.Pedido.Produtos) {
                            quantidade += Produto.Quantidade;
                }


                return quantidade;     

    }

    constructor(private _pedidoService: PedidoService) {
    }


    @HostListener("window:scroll", ["$event"])
    @HostListener("window:resize", ["$event"])
    Scroll(event) {

        if(window.pageYOffset > 200) {
                this.TopHeaderClass = "fixed";
        } else {
                this.TopHeaderClass = "";
        }
              
    }

    ngOnInit() {

            this._pedidoService.GetCurrentPedido().subscribe((Pedido: PedidoModel) => {

                    this.Pedido = Pedido;

                    if(this.Pedido == undefined)
                    this.Pedido = new PedidoModel();

            });


            CestaProdutoService.listen().subscribe((Pedido:PedidoModel) => {

                    this.Pedido = Pedido;

            })

    }


}