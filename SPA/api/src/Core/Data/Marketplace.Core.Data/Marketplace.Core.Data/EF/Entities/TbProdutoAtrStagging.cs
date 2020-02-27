﻿using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbProdutoAtrStagging
    {
        public int IdProdutoAtrStagging { get; set; }
        public string CdBarras { get; set; }
        public int IdProduto { get; set; }
        public decimal NuPeso { get; set; }
        public int NuAltura { get; set; }
        public int NuLargura { get; set; }
        public int NuProfundidade { get; set; }
        public string NmProdutoSku { get; set; }
        public string CdMs { get; set; }
        public string NmProduto { get; set; }
    }
}
