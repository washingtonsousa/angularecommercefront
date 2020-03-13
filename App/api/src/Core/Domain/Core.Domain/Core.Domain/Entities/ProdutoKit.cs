using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoKit
    {
        public int IdProdutoKit { get; set; }
        public int IdProduto { get; set; }
        public int IdProdutoSku { get; set; }
        public int NuQuantidade { get; set; }

        public virtual Produto IdProdutoNavigation { get; set; }
        public virtual ProdutoSku IdProdutoSkuNavigation { get; set; }
    }
}
