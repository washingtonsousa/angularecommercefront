using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbProdutoTipoStagging
    {
        public int IdProdutoFamiliaStagging { get; set; }
        public string CdBarras { get; set; }
        public int IdProdutoTipo { get; set; }
        public int IdProduto { get; set; }
    }
}
