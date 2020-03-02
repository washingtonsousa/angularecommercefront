﻿using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbQuemComprouComprouTambem
    {
        public int IdQuemComprouComprouTambem { get; set; }
        public int IdProdutoSku { get; set; }
        public int IdProdutoSkuComprado { get; set; }
        public int NuQuantidade { get; set; }

        public virtual ProdutoSku IdProdutoSkuNavigation { get; set; }
    }
}
