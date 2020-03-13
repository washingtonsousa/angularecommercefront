using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class LojaEspecialCategoria
    {
        public LojaEspecialCategoria()
        {
            LojaEspecialProduto = new HashSet<LojaEspecialProduto>();
        }

        public int IdLojaEspecialCategoria { get; set; }
        public int IdLojaEspecialSecao { get; set; }
        public bool FlStatus { get; set; }
        public byte NuOrdem { get; set; }
        public string NmCategoria { get; set; }

        public virtual LojaEspecialSecao IdLojaEspecialSecaoNavigation { get; set; }
        public virtual ICollection<LojaEspecialProduto> LojaEspecialProduto { get; set; }
    }
}
