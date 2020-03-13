using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class BannerTarget
    {
        public BannerTarget()
        {
            Banner = new HashSet<Banner>();
        }

        public int IdBannerTarget { get; set; }
        public string NmBannerTarget { get; set; }

        public virtual ICollection<Banner> Banner { get; set; }
    }
}
