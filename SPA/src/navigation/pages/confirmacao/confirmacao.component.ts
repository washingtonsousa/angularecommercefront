import { Component, OnInit } from '@angular/core';
import { PedidoService } from 'src/services/pedido.service';
import { PedidoModel } from 'src/shared/models/pedido.model';
import { CestaProdutoService } from 'src/services/emitters/cesta-produto-emitter.service';

@Component({
   selector: 'confirmacao',
   templateUrl: 'confirmacao.component.html'
})
export class ConfirmacaoComponent implements OnInit {

 private Pedido?: PedidoModel;

 constructor(private _pedidoService: PedidoService){}

 ngOnInit() {
   
   this._pedidoService.GetCurrentPedido().subscribe((Pedido: PedidoModel) => {
      this.Pedido = Pedido;

            let pedidoNovo = new PedidoModel();

            this._pedidoService.UpdatePedido(pedidoNovo).subscribe(() => {

                     CestaProdutoService.update(pedidoNovo);

            });




   });

 }

}