using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Especificacao
    {
        public Especificacao()
        {
            ProdutoSkuEspecificacaoIdEspecificacao1Navigation = new HashSet<ProdutoSkuEspecificacao>();
            ProdutoSkuEspecificacaoIdEspecificacao2Navigation = new HashSet<ProdutoSkuEspecificacao>();
        }

        public int IdEspecificacao { get; set; }
        public int IdEspecificacaoTipo { get; set; }
        public byte NuOrdem { get; set; }
        public string NmEspecificacao { get; set; }
        public string DsImagem { get; set; }
        public string DsHexadecimal { get; set; }
        public string CdExterno { get; set; }

        public virtual EspecificacaoTipo IdEspecificacaoTipoNavigation { get; set; }
        public virtual ICollection<ProdutoSkuEspecificacao> ProdutoSkuEspecificacaoIdEspecificacao1Navigation { get; set; }
        public virtual ICollection<ProdutoSkuEspecificacao> ProdutoSkuEspecificacaoIdEspecificacao2Navigation { get; set; }
    }
}
