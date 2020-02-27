using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbListaDesejoProdutoSku
    {
        public int IdListaDesejoProdutoSku { get; set; }
        public int IdListaDesejo { get; set; }
        public int IdProdutoSku { get; set; }

        public virtual TbListaDesejo IdListaDesejoNavigation { get; set; }
        public virtual TbProdutoSku IdProdutoSkuNavigation { get; set; }
    }
}
