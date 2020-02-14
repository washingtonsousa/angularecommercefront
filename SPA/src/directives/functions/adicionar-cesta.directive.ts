import {Directive, HostListener, Input, Output, EventEmitter} from "@angular/core";
import { ProdutoModel } from 'src/shared/models/produto.model';
import { PedidoService } from 'src/services/pedido.service';
import { PedidoModel } from 'src/shared/models/pedido.model';
import { Router } from '@angular/router';
import { LoadingIconService } from 'src/services/emitters/loading-icon.service';
import { CestaProdutoService } from 'src/services/emitters/cesta-produto-emitter.service';

@Directive({
   selector: "[AdicionarCesta]"
})
export class AdicionarCestaDirective {

    @Input() Produto: ProdutoModel;
    @Input() Quantidade: number;
    @Output() OnAdd: EventEmitter<any> = new EventEmitter<any>();

    constructor(private _pedidoService: PedidoService, private _router: Router) {}

    @HostListener("click", ["$event"])
    Click() {

        LoadingIconService.show();

            this._pedidoService.GetCurrentPedido().subscribe((Pedido: PedidoModel) => {

                if(Pedido == null || Pedido == undefined)    
                Pedido = new PedidoModel();

                this.AddProdutoProcess(Pedido);
                LoadingIconService.hide();

            });
            
    }

    private AddProdutoProcess(Pedido: PedidoModel) {

        try {

            let produto = Pedido.Produtos.filter((produto: ProdutoModel) => {

                return (this.Produto.Codigo == produto.Codigo);
    
            })[0];

            produto.Quantidade += this.Quantidade;

        } catch(ex) {

            this.Produto.Quantidade = this.Quantidade;
            Pedido.Produtos.push(this.Produto);  

        }

        Pedido.Total = 0;
        Pedido.SubTotal = 0;
        
        Pedido.Produtos.forEach((produto) => {

            Pedido.Total += produto.Preco_Por * produto.Quantidade;
            Pedido.SubTotal += produto.Preco_Por * produto.Quantidade;

        });

        this._pedidoService.UpdatePedido(Pedido).subscribe(() => {

            CestaProdutoService.update(Pedido);
            this.OnAdd.emit();

        });
                
    }

}
