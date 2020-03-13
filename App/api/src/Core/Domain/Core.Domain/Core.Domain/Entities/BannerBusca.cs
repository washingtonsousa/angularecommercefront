using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class BannerBusca
    {
        public int IdBannerBusca { get; set; }
        public int IdBanner { get; set; }
        public string DsTermoBusca { get; set; }

        public virtual Banner IdBannerNavigation { get; set; }
    }
}
