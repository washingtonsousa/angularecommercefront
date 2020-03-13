using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoSkuFiltro
    {
        public int IdProdutoSkuFiltro { get; set; }
        public int IdProdutoSku { get; set; }
        public int IdFiltro { get; set; }

        public virtual Filtro IdFiltroNavigation { get; set; }
        public virtual ProdutoSku IdProdutoSkuNavigation { get; set; }
    }
}
