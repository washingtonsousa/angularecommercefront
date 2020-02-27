using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbPedidoProdutoKit
    {
        public int IdPedidoProdutoKit { get; set; }
        public int IdPedidoProdutoSku { get; set; }
        public int IdProdutoItem { get; set; }
        public int NuQuantidade { get; set; }

        public virtual TbPedidoProdutoSku IdPedidoProdutoSkuNavigation { get; set; }
        public virtual TbProdutoSku IdProdutoItemNavigation { get; set; }
    }
}
