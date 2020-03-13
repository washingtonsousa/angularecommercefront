using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class BannerProduto
    {
        public int IdBannerProduto { get; set; }
        public int IdBanner { get; set; }
        public int IdProduto { get; set; }

        public virtual Banner IdBannerNavigation { get; set; }
        public virtual Produto IdProdutoNavigation { get; set; }
    }
}
