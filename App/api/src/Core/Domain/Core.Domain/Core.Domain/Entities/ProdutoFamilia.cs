using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoFamilia
    {
        public ProdutoFamilia()
        {
            MensagemProdutoFamilia = new HashSet<MensagemProdutoFamilia>();
            Produto = new HashSet<Produto>();
            ProdutoFamiliaModalidade = new HashSet<ProdutoFamiliaModalidade>();
        }

        public int IdProdutoFamilia { get; set; }
        public string DsProdutoFamilia { get; set; }
        public string DsImagem { get; set; }

        public virtual ICollection<MensagemProdutoFamilia> MensagemProdutoFamilia { get; set; }
        public virtual ICollection<Produto> Produto { get; set; }
        public virtual ICollection<ProdutoFamiliaModalidade> ProdutoFamiliaModalidade { get; set; }
    }
}
