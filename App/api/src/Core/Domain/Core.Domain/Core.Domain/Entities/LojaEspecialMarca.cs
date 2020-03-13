using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class LojaEspecialMarca
    {
        public int IdLojaEspecialMarca { get; set; }
        public int IdLojaEspecial { get; set; }
        public int IdMarca { get; set; }

        public virtual LojaEspecial IdLojaEspecialNavigation { get; set; }
        public virtual Marca IdMarcaNavigation { get; set; }
    }
}
