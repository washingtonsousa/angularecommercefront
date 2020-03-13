using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class LojaEspecialDepartamento
    {
        public LojaEspecialDepartamento()
        {
            LojaEspecialProduto = new HashSet<LojaEspecialProduto>();
            LojaEspecialSecao = new HashSet<LojaEspecialSecao>();
        }

        public int IdLojaEspecialDepartamento { get; set; }
        public int IdLojaEspecial { get; set; }
        public bool FlStatus { get; set; }
        public byte NuOrdem { get; set; }
        public string NmDepartamento { get; set; }

        public virtual LojaEspecial IdLojaEspecialNavigation { get; set; }
        public virtual ICollection<LojaEspecialProduto> LojaEspecialProduto { get; set; }
        public virtual ICollection<LojaEspecialSecao> LojaEspecialSecao { get; set; }
    }
}
