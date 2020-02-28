import { ProdutoImagemModel } from './produto-imagem.model';
import { MarcaModel } from './marca.model';

export class ProdutoModel {
            public Imagens: ProdutoImagemModel[] = [];
            public ImagemPrincipal: ProdutoImagemModel;
            public Imagem: ProdutoImagemModel;
            public Nome: String;
            public Codigo:  String;
            public Preco_Por: number;
            public Marca: MarcaModel; 
            public Quantidade: number;
}