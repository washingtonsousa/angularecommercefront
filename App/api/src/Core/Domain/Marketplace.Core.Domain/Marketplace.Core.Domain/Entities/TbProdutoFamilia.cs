using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbProdutoFamilia
    {
        public TbProdutoFamilia()
        {
            TbMensagemProdutoFamilia = new HashSet<TbMensagemProdutoFamilia>();
            TbProduto = new HashSet<TbProduto>();
            TbProdutoFamiliaModalidade = new HashSet<TbProdutoFamiliaModalidade>();
        }

        public int IdProdutoFamilia { get; set; }
        public string DsProdutoFamilia { get; set; }
        public string DsImagem { get; set; }

        public virtual ICollection<TbMensagemProdutoFamilia> TbMensagemProdutoFamilia { get; set; }
        public virtual ICollection<TbProduto> TbProduto { get; set; }
        public virtual ICollection<TbProdutoFamiliaModalidade> TbProdutoFamiliaModalidade { get; set; }
    }
}
