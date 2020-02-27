using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbBannerTarget
    {
        public TbBannerTarget()
        {
            TbBanner = new HashSet<TbBanner>();
        }

        public int IdBannerTarget { get; set; }
        public string NmBannerTarget { get; set; }

        public virtual ICollection<TbBanner> TbBanner { get; set; }
    }
}
