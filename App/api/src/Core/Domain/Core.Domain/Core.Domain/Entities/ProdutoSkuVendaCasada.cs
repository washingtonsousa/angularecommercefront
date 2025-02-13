﻿using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoSkuVendaCasada
    {
        public int IdProdutoSkuVendaCasada { get; set; }
        public int IdProdutoSku { get; set; }
        public int IdProdutoSkuCasado { get; set; }
        public bool? FlTipoDesconto { get; set; }
        public decimal? VlDesconto { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }

        public virtual ProdutoSku IdProdutoSkuCasadoNavigation { get; set; }
        public virtual ProdutoSku IdProdutoSkuNavigation { get; set; }
    }
}
