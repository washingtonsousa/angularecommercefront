﻿using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbProdutoSkuFiltro
    {
        public int IdProdutoSkuFiltro { get; set; }
        public int IdProdutoSku { get; set; }
        public int IdFiltro { get; set; }

        public virtual TbFiltro IdFiltroNavigation { get; set; }
        public virtual TbProdutoSku IdProdutoSkuNavigation { get; set; }
    }
}
