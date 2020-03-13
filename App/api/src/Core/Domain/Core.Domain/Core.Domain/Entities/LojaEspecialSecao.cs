using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class LojaEspecialSecao
    {
        public LojaEspecialSecao()
        {
            LojaEspecialCategoria = new HashSet<LojaEspecialCategoria>();
            LojaEspecialProduto = new HashSet<LojaEspecialProduto>();
        }

        public int IdLojaEspecialSecao { get; set; }
        public int IdLojaEspecialDepartamento { get; set; }
        public bool FlStatus { get; set; }
        public byte NuOrdem { get; set; }
        public string NmSecao { get; set; }

        public virtual LojaEspecialDepartamento IdLojaEspecialDepartamentoNavigation { get; set; }
        public virtual ICollection<LojaEspecialCategoria> LojaEspecialCategoria { get; set; }
        public virtual ICollection<LojaEspecialProduto> LojaEspecialProduto { get; set; }
    }
}
