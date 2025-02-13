﻿using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class CategoriaSeo
    {
        public int IdCategoriaSeo { get; set; }
        public int IdCategoria { get; set; }
        public string DsDescription { get; set; }
        public string DsTitle { get; set; }
        public string DsKeywords { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
    }
}
