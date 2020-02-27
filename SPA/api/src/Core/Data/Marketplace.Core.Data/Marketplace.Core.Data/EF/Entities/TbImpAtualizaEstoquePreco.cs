﻿using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbImpAtualizaEstoquePreco
    {
        public int IdImportacao { get; set; }
        public string Codigo { get; set; }
        public int NuEstoque { get; set; }
        public decimal VlProdutoDe { get; set; }
        public decimal VlProdutoPor { get; set; }
        public DateTime DtImportacao { get; set; }
        public bool FlStatus { get; set; }
        public string DsMensagem { get; set; }
        public int? IdPraca { get; set; }
    }
}
