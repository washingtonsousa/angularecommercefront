using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbProdutoControleStagging
    {
        public int IdProdutoControleStagging { get; set; }
        public string CdBarras { get; set; }
        public int IdProdutoControle { get; set; }
        public int IdProduto { get; set; }
    }
}
