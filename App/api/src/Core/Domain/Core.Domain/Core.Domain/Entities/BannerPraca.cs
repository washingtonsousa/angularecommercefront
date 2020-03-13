using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class BannerPraca
    {
        public int IdBannerPraca { get; set; }
        public int IdBanner { get; set; }
        public int IdPraca { get; set; }

        public virtual Banner IdBannerNavigation { get; set; }
        public virtual Praca IdPracaNavigation { get; set; }
    }
}
