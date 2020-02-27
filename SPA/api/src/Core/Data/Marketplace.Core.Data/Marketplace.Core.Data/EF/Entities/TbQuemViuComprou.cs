using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbQuemViuComprou
    {
        public int IdQuemViuComprou { get; set; }
        public int IdProdutoSkuVisto { get; set; }
        public int IdProdutoSkuComprado { get; set; }
        public int NuQuantidade { get; set; }

        public virtual TbProdutoSku IdProdutoSkuCompradoNavigation { get; set; }
        public virtual TbProdutoSku IdProdutoSkuVistoNavigation { get; set; }
    }
}
