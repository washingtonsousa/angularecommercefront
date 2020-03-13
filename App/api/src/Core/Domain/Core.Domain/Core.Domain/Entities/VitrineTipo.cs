using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class VitrineTipo
    {
        public VitrineTipo()
        {
            Vitrine = new HashSet<Vitrine>();
        }

        public int IdVitrineTipo { get; set; }
        public string NmVitrineTipo { get; set; }

        public virtual ICollection<Vitrine> Vitrine { get; set; }
    }
}
