using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbConteudoLocal
    {
        public TbConteudoLocal()
        {
            TbConteudoConteudoLocal = new HashSet<TbConteudoConteudoLocal>();
        }

        public int IdConteudoLocal { get; set; }
        public string NmConteudoLocal { get; set; }

        public virtual ICollection<TbConteudoConteudoLocal> TbConteudoConteudoLocal { get; set; }
    }
}
