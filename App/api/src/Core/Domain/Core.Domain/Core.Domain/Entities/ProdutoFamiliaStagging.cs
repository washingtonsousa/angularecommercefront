using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoFamiliaStagging
    {
        public int IdProdutoFamiliaStagging { get; set; }
        public string CdBarras { get; set; }
        public int IdProdutoFamilia { get; set; }
        public int IdProduto { get; set; }
    }
}
