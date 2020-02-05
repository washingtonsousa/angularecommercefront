import { ProdutoModel } from './produto.model';
import { ProdutoDescricaoModel } from './produto-descricao.model';



export class PedidoModel {

    constructor() {
            this.Numero = Math.floor(Math.random() * 100000).toString();
    }

    public Produtos: ProdutoModel[] = [];
    public Numero: String = "";


}