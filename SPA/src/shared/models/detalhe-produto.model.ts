import { ProdutoModel } from './produto.model';
import { ProdutoDescricaoModel } from './produto-descricao.model';

export class DetalheProdutoModel {
    public Produto: ProdutoModel;
    public Descricoes : ProdutoDescricaoModel[] = [];
}