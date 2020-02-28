using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbBannerProduto
    {
        public int IdBannerProduto { get; set; }
        public int IdBanner { get; set; }
        public int IdProduto { get; set; }

        public virtual TbBanner IdBannerNavigation { get; set; }
        public virtual TbProduto IdProdutoNavigation { get; set; }
    }
}
