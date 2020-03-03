using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbProdutoDescricao
    {
        public int IdProdutoDescricao { get; set; }
        public int IdProdutoDescricaoTipo { get; set; }
        public int IdProduto { get; set; }
        public bool FlStatus { get; set; }
        public string TxProdutoDescricao { get; set; }
        public byte NuOrdem { get; set; }
        public bool? FlTxProdutoTipo { get; set; }

        public virtual TbProdutoDescricaoTipo IdProdutoDescricaoTipoNavigation { get; set; }
        public virtual TbProduto IdProdutoNavigation { get; set; }
    }
}
