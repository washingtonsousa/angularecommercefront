using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbBannerCategoria
    {
        public int IdBannerCategoria { get; set; }
        public int IdBanner { get; set; }
        public int IdCategoria { get; set; }

        public virtual TbBanner IdBannerNavigation { get; set; }
        public virtual Categoria IdCategoriaNavigation { get; set; }
    }
}
