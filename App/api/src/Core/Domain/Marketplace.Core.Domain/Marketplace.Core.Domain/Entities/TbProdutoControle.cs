using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbProdutoControle
    {
        public TbProdutoControle()
        {
            TbMensagemProdutoControle = new HashSet<TbMensagemProdutoControle>();
            TbProduto = new HashSet<TbProduto>();
        }

        public int IdProdutoControle { get; set; }
        public string DsProdutoControle { get; set; }

        public virtual ICollection<TbMensagemProdutoControle> TbMensagemProdutoControle { get; set; }
        public virtual ICollection<TbProduto> TbProduto { get; set; }
    }
}
