import { Component, Input } from '@angular/core';
import { ProdutoModel } from 'src/shared/models/produto.model';

@Component({
    selector: 'product-card',
    templateUrl: 'product-card.component.html',
    styleUrls: ["product-card.scss"]
})
export class ProductCardComponent {
       @Input() public Produto: ProdutoModel;
       @Input() public Carrosel: boolean = true;
}