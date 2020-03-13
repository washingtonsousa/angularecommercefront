using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class GondolaProdutoSku
    {
        public int IdGondolaProdutoSku { get; set; }
        public int IdGondola { get; set; }
        public int IdProdutoSku { get; set; }

        public virtual ProdutoSku IdProdutoSkuNavigation { get; set; }
    }
}
