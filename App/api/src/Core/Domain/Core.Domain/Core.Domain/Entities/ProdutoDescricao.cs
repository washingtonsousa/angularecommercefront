using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoDescricao
    {
        public int IdProdutoDescricao { get; set; }
        public int IdProdutoDescricaoTipo { get; set; }
        public int IdProduto { get; set; }
        public bool FlStatus { get; set; }
        public string TxProdutoDescricao { get; set; }
        public byte NuOrdem { get; set; }
        public bool? FlTxProdutoTipo { get; set; }

        public virtual ProdutoDescricaoTipo IdProdutoDescricaoTipoNavigation { get; set; }
        public virtual Produto IdProdutoNavigation { get; set; }
    }
}
