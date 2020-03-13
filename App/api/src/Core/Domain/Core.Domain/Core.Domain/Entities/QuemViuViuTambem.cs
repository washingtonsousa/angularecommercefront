using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class QuemViuViuTambem
    {
        public int IdQuemViuViuTambem { get; set; }
        public int IdProdutoSku { get; set; }
        public int IdProdutoSkuVisto { get; set; }
        public int NuQuantidade { get; set; }

        public virtual ProdutoSku IdProdutoSkuNavigation { get; set; }
        public virtual ProdutoSku IdProdutoSkuVistoNavigation { get; set; }
    }
}
