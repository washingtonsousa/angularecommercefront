using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbQuemViuViuTambem
    {
        public int IdQuemViuViuTambem { get; set; }
        public int IdProdutoSku { get; set; }
        public int IdProdutoSkuVisto { get; set; }
        public int NuQuantidade { get; set; }

        public virtual TbProdutoSku IdProdutoSkuNavigation { get; set; }
        public virtual TbProdutoSku IdProdutoSkuVistoNavigation { get; set; }
    }
}
