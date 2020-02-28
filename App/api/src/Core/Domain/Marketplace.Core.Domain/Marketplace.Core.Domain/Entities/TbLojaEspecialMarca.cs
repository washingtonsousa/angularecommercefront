using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbLojaEspecialMarca
    {
        public int IdLojaEspecialMarca { get; set; }
        public int IdLojaEspecial { get; set; }
        public int IdMarca { get; set; }

        public virtual TbLojaEspecial IdLojaEspecialNavigation { get; set; }
        public virtual TbMarca IdMarcaNavigation { get; set; }
    }
}
