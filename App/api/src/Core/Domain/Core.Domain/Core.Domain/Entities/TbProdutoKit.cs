using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbProdutoKit
    {
        public int IdProdutoKit { get; set; }
        public int IdProduto { get; set; }
        public int IdProdutoSku { get; set; }
        public int NuQuantidade { get; set; }

        public virtual TbProduto IdProdutoNavigation { get; set; }
        public virtual ProdutoSku IdProdutoSkuNavigation { get; set; }
    }
}
