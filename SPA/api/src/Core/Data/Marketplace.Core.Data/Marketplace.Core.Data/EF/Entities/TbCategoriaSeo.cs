using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbCategoriaSeo
    {
        public int IdCategoriaSeo { get; set; }
        public int IdCategoria { get; set; }
        public string DsDescription { get; set; }
        public string DsTitle { get; set; }
        public string DsKeywords { get; set; }

        public virtual TbCategoria IdCategoriaNavigation { get; set; }
    }
}
