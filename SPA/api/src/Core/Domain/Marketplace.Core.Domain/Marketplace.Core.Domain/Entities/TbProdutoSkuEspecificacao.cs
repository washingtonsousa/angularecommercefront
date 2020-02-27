using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbProdutoSkuEspecificacao
    {
        public int IdProdutoSkuEspecificacao { get; set; }
        public int IdProdutoSku { get; set; }
        public int IdEspecificacao1 { get; set; }
        public int? IdEspecificacao2 { get; set; }

        public virtual TbEspecificacao IdEspecificacao1Navigation { get; set; }
        public virtual TbEspecificacao IdEspecificacao2Navigation { get; set; }
        public virtual TbProdutoSku IdProdutoSkuNavigation { get; set; }
    }
}
