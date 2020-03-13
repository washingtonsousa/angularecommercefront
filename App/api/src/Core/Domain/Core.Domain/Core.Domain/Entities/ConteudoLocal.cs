using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ConteudoLocal
    {
        public ConteudoLocal()
        {
            ConteudoConteudoLocal = new HashSet<ConteudoConteudoLocal>();
        }

        public int IdConteudoLocal { get; set; }
        public string NmConteudoLocal { get; set; }

        public virtual ICollection<ConteudoConteudoLocal> ConteudoConteudoLocal { get; set; }
    }
}
