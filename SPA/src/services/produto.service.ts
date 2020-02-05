import { Injectable } from "@angular/core";
import { ProdutoModel } from 'src/shared/models/produto.model';
import * as produtoJsons from "src/shared/json/examples/produto";


//Temp para protótipo

@Injectable()
export class ProdutoService {


    GetDetalheProduto(Codigo: String) {

        let produto =  produtoJsons.ProdutoDetalhes.filter((produto) => {
                return produto.Produto.Codigo == Codigo;
        });

        return produto[0];
    }

    Get() : ProdutoModel[] {
        console.log(produtoJsons.Produtos);
        return produtoJsons.Produtos;

    }
}
