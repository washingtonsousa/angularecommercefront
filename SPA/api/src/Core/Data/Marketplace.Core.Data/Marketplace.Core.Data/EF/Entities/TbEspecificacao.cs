using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbEspecificacao
    {
        public TbEspecificacao()
        {
            TbProdutoSkuEspecificacaoIdEspecificacao1Navigation = new HashSet<TbProdutoSkuEspecificacao>();
            TbProdutoSkuEspecificacaoIdEspecificacao2Navigation = new HashSet<TbProdutoSkuEspecificacao>();
        }

        public int IdEspecificacao { get; set; }
        public int IdEspecificacaoTipo { get; set; }
        public byte NuOrdem { get; set; }
        public string NmEspecificacao { get; set; }
        public string DsImagem { get; set; }
        public string DsHexadecimal { get; set; }
        public string CdExterno { get; set; }

        public virtual TbEspecificacaoTipo IdEspecificacaoTipoNavigation { get; set; }
        public virtual ICollection<TbProdutoSkuEspecificacao> TbProdutoSkuEspecificacaoIdEspecificacao1Navigation { get; set; }
        public virtual ICollection<TbProdutoSkuEspecificacao> TbProdutoSkuEspecificacaoIdEspecificacao2Navigation { get; set; }
    }
}
