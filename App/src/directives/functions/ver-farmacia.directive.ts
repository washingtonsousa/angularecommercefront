import {Directive, HostListener, Input} from "@angular/core";
import { ProdutoModel } from 'src/shared/models/produto.model';
import { PedidoService } from 'src/services/pedido.service';
import { PedidoModel } from 'src/shared/models/pedido.model';
import { Router } from '@angular/router';
import { LoadingIconService } from 'src/services/emitters/loading-icon.service';

@Directive({
   selector: "[VerFarmacia]"
})
export class VerFarmaciaDirective {

    @Input() Produto: ProdutoModel;
    @Input() Quantidade: number;

    constructor(private _pedidoService: PedidoService, private _router: Router) {}

    @HostListener("click", ["$event"])
    Click(event) {

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
            this.Produto.Quantidade += this.Quantidade;
              Pedido.Produtos.push(this.Produto);  

        }
        
        Pedido.Total = 0;
        Pedido.SubTotal = 0;

        Pedido.Produtos.forEach((produto) => {

            Pedido.Total += produto.Preco_Por * produto.Quantidade;
            Pedido.SubTotal += produto.Preco_Por * produto.Quantidade;

        })

        this._pedidoService.UpdatePedido(Pedido).subscribe(() => {

            this._router.navigate(["/carrinho"]);

        });
        
    }

}
