﻿using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbParceiroXmlProduto
    {
        public int IdParceiroXmlProduto { get; set; }
        public int IdParceiro { get; set; }
        public int IdProdutoSku { get; set; }

        public virtual TbParceiro IdParceiroNavigation { get; set; }
        public virtual ProdutoSku IdProdutoSkuNavigation { get; set; }
    }
}
