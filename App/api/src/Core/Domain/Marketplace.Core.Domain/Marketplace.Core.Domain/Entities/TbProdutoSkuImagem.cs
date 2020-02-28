using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbProdutoSkuImagem
    {
        public int IdProdutoSkuImagem { get; set; }
        public int IdProdutoSku { get; set; }
        public bool FlStatus { get; set; }
        public bool FlPrincipal { get; set; }
        public bool? FlSecundaria { get; set; }
        public string DsImagem { get; set; }
        public string AltImg { get; set; }

        public virtual TbProdutoSku IdProdutoSkuNavigation { get; set; }
    }
}
