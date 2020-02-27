using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbBannerPraca
    {
        public int IdBannerPraca { get; set; }
        public int IdBanner { get; set; }
        public int IdPraca { get; set; }

        public virtual TbBanner IdBannerNavigation { get; set; }
        public virtual TbPraca IdPracaNavigation { get; set; }
    }
}
