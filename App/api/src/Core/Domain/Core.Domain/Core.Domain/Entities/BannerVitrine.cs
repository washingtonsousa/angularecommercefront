using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class BannerVitrine
    {
        public int IdBannerVitrine { get; set; }
        public int IdBanner { get; set; }
        public int IdVitrine { get; set; }

        public virtual Banner IdBannerNavigation { get; set; }
        public virtual Vitrine IdVitrineNavigation { get; set; }
    }
}
