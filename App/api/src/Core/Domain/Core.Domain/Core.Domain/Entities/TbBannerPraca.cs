using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbBannerPraca
    {
        public int IdBannerPraca { get; set; }
        public int IdBanner { get; set; }
        public int IdPraca { get; set; }

        public virtual TbBanner IdBannerNavigation { get; set; }
        public virtual Praca IdPracaNavigation { get; set; }
    }
}
