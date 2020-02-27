using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbProdutoTipo
    {
        public TbProdutoTipo()
        {
            TbMensagemProdutoTipo = new HashSet<TbMensagemProdutoTipo>();
            TbProduto = new HashSet<TbProduto>();
        }

        public int IdProdutoTipo { get; set; }
        public string DsProdutoTipo { get; set; }

        public virtual ICollection<TbMensagemProdutoTipo> TbMensagemProdutoTipo { get; set; }
        public virtual ICollection<TbProduto> TbProduto { get; set; }
    }
}
