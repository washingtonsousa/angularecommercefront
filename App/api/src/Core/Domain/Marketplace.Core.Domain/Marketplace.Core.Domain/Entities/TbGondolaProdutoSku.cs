using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbGondolaProdutoSku
    {
        public int IdGondolaProdutoSku { get; set; }
        public int IdGondola { get; set; }
        public int IdProdutoSku { get; set; }

        public virtual TbProdutoSku IdProdutoSkuNavigation { get; set; }
    }
}
