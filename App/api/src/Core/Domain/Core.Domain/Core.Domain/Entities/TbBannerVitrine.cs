using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbBannerVitrine
    {
        public int IdBannerVitrine { get; set; }
        public int IdBanner { get; set; }
        public int IdVitrine { get; set; }

        public virtual TbBanner IdBannerNavigation { get; set; }
        public virtual TbVitrine IdVitrineNavigation { get; set; }
    }
}
