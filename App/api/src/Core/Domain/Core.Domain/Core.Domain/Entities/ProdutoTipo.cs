using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoTipo
    {
        public ProdutoTipo()
        {
            MensagemProdutoTipo = new HashSet<MensagemProdutoTipo>();
            Produto = new HashSet<Produto>();
        }

        public int IdProdutoTipo { get; set; }
        public string DsProdutoTipo { get; set; }

        public virtual ICollection<MensagemProdutoTipo> MensagemProdutoTipo { get; set; }
        public virtual ICollection<Produto> Produto { get; set; }
    }
}
