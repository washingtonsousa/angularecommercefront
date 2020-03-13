using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class LojaEspecialVitrine
    {
        public LojaEspecialVitrine()
        {
            LojaEspecialVitrineProduto = new HashSet<LojaEspecialVitrineProduto>();
        }

        public int IdLojaEspecialVitrine { get; set; }
        public int IdLojaEspecial { get; set; }
        public bool FlStatus { get; set; }
        public byte NuOrdem { get; set; }
        public string NmVitrine { get; set; }

        public virtual LojaEspecial IdLojaEspecialNavigation { get; set; }
        public virtual ICollection<LojaEspecialVitrineProduto> LojaEspecialVitrineProduto { get; set; }
    }
}
