using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbBannerCategoria
    {
        public int IdBannerCategoria { get; set; }
        public int IdBanner { get; set; }
        public int IdCategoria { get; set; }

        public virtual TbBanner IdBannerNavigation { get; set; }
        public virtual TbCategoria IdCategoriaNavigation { get; set; }
    }
}
