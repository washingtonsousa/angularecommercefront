import {Directive, HostListener, Input, Output, EventEmitter} from "@angular/core";
import { ProdutoModel } from 'src/shared/models/produto.model';
import { PedidoService } from 'src/services/pedido.service';
import { PedidoModel } from 'src/shared/models/pedido.model';
import { Router } from '@angular/router';
import { LoadingIconService } from 'src/services/emitters/loading-icon.service';
import { CestaProdutoService } from 'src/services/emitters/cesta-produto-emitter.service';

@Directive({
   selector: "[RemoverCesta]"
})
export class RemoverCestaDirective {

    @Input() Produto: ProdutoModel;
    @Output() OnRemove: EventEmitter<any> = new EventEmitter<any>();
    @Input() RemoverUnidade: boolean = false;

    constructor(private _pedidoService: PedidoService, private _router: Router) {}

    @HostListener("click", ["$event"])
    Click() {

        LoadingIconService.show();

            this._pedidoService.GetCurrentPedido().subscribe((Pedido: PedidoModel) => {

                if(Pedido == null || Pedido == undefined)    
                Pedido = new PedidoModel();

                this.RemoverProdutoProcess(Pedido);
                LoadingIconService.hide();

            });
            
    }

    private RemoverProdutoProcess(Pedido: PedidoModel) {

    
            let index = 0;

            for(let produto of Pedido.Produtos) {

                if(this.Produto.Codigo == produto.Codigo) {

                        if(produto.Quantidade == 1 || !this.RemoverUnidade) {

                                Pedido.Produtos.splice(index, 1);

                        } else {

                            produto.Quantidade -= 1;
                            
                        }
                }
                
            }

        Pedido.Total = 0;
        Pedido.SubTotal = 0;

        Pedido.Produtos.forEach((produto) => {

            Pedido.Total += produto.Preco_Por * produto.Quantidade;
            Pedido.SubTotal += produto.Preco_Por * produto.Quantidade;

        })

        this._pedidoService.UpdatePedido(Pedido).subscribe(() => {

            CestaProdutoService.update(Pedido);
            this.OnRemove.emit();

        });
        
    }

}
