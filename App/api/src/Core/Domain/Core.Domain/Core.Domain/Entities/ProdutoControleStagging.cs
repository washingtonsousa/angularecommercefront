using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoControleStagging
    {
        public int IdProdutoControleStagging { get; set; }
        public string CdBarras { get; set; }
        public int IdProdutoControle { get; set; }
        public int IdProduto { get; set; }
    }
}
