using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbPedidoProdutoKit
    {
        public int IdPedidoProdutoKit { get; set; }
        public int IdPedidoProdutoSku { get; set; }
        public int IdProdutoItem { get; set; }
        public int NuQuantidade { get; set; }

        public virtual PedidoProdutoSku IdPedidoProdutoSkuNavigation { get; set; }
        public virtual ProdutoSku IdProdutoItemNavigation { get; set; }
    }
}
