using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbProdutoFamiliaStagging
    {
        public int IdProdutoFamiliaStagging { get; set; }
        public string CdBarras { get; set; }
        public int IdProdutoFamilia { get; set; }
        public int IdProduto { get; set; }
    }
}
