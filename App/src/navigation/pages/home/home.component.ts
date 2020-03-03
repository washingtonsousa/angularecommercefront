import { Component, OnInit } from '@angular/core';
import { ProdutoService } from 'src/services/produto.service';
import { ProdutoModel } from 'src/shared/models/produto.model';


@Component({
    selector: 'home-app',
    templateUrl: 'home.component.html'
})
export class HomeComponent implements OnInit {

    public Produtos: ProdutoModel[] = [];

    constructor(public _produtoService: ProdutoService) {
    }

    ngOnInit() {
        this.Produtos = this._produtoService.Get();
    }

}