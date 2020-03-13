using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class LojaEspecialProduto
    {
        public int IdLojaEspecialProduto { get; set; }
        public int IdProduto { get; set; }
        public int IdLojaEspecial { get; set; }
        public int IdLojaEspecialDepartamento { get; set; }
        public int? IdLojaEspecialSecao { get; set; }
        public int? IdLojaEspecialCategoria { get; set; }

        public virtual LojaEspecialCategoria IdLojaEspecialCategoriaNavigation { get; set; }
        public virtual LojaEspecialDepartamento IdLojaEspecialDepartamentoNavigation { get; set; }
        public virtual LojaEspecial IdLojaEspecialNavigation { get; set; }
        public virtual LojaEspecialSecao IdLojaEspecialSecaoNavigation { get; set; }
        public virtual Produto IdProdutoNavigation { get; set; }
    }
}
