import { Component, OnInit } from '@angular/core';
import { ProdutoService } from 'src/services/produto.service';
import { DetalheProdutoModel } from 'src/shared/models/detalhe-produto.model';
import { Router, ActivatedRoute } from '@angular/router';
import { PedidoService } from 'src/services/pedido.service';

@Component({
    selector: 'detalhe-produto',
    templateUrl: 'detalhe-produto.component.html'
})
export class DetalheProdutoComponent implements OnInit {

        public DetalheProduto: DetalheProdutoModel = new DetalheProdutoModel();   
        
        constructor(private produtoService: ProdutoService, private router: ActivatedRoute, private _pedidoService: PedidoService) {}

        ngOnInit() {
              this.DetalheProduto = this.produtoService.GetDetalheProduto(this.router.snapshot.params['sku']);
        }    
    
}