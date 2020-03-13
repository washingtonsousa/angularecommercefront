using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoControle
    {
        public ProdutoControle()
        {
            MensagemProdutoControle = new HashSet<MensagemProdutoControle>();
            Produto = new HashSet<Produto>();
        }

        public int IdProdutoControle { get; set; }
        public string DsProdutoControle { get; set; }

        public virtual ICollection<MensagemProdutoControle> MensagemProdutoControle { get; set; }
        public virtual ICollection<Produto> Produto { get; set; }
    }
}
