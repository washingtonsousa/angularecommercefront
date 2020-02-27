﻿using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbVitrineTipo
    {
        public TbVitrineTipo()
        {
            TbVitrine = new HashSet<TbVitrine>();
        }

        public int IdVitrineTipo { get; set; }
        public string NmVitrineTipo { get; set; }

        public virtual ICollection<TbVitrine> TbVitrine { get; set; }
    }
}
