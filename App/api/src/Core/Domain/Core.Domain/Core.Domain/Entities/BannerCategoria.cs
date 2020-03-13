using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class BannerCategoria
    {
        public int IdBannerCategoria { get; set; }
        public int IdBanner { get; set; }
        public int IdCategoria { get; set; }

        public virtual Banner IdBannerNavigation { get; set; }
        public virtual Categoria IdCategoriaNavigation { get; set; }
    }
}
