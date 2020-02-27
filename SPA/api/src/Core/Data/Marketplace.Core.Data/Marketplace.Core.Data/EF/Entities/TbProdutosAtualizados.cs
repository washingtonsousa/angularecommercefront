using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbProdutosAtualizados
    {
        public string CdBarras { get; set; }
        public int IdProduto { get; set; }
        public string Fonte { get; set; }
    }
}
