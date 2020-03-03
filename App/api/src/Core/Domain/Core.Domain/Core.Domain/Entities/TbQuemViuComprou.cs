using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbQuemViuComprou
    {
        public int IdQuemViuComprou { get; set; }
        public int IdProdutoSkuVisto { get; set; }
        public int IdProdutoSkuComprado { get; set; }
        public int NuQuantidade { get; set; }

        public virtual ProdutoSku IdProdutoSkuCompradoNavigation { get; set; }
        public virtual ProdutoSku IdProdutoSkuVistoNavigation { get; set; }
    }
}
