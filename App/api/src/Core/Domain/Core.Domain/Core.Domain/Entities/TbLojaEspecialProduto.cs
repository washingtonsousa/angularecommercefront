using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbLojaEspecialProduto
    {
        public int IdLojaEspecialProduto { get; set; }
        public int IdProduto { get; set; }
        public int IdLojaEspecial { get; set; }
        public int IdLojaEspecialDepartamento { get; set; }
        public int? IdLojaEspecialSecao { get; set; }
        public int? IdLojaEspecialCategoria { get; set; }

        public virtual TbLojaEspecialCategoria IdLojaEspecialCategoriaNavigation { get; set; }
        public virtual TbLojaEspecialDepartamento IdLojaEspecialDepartamentoNavigation { get; set; }
        public virtual TbLojaEspecial IdLojaEspecialNavigation { get; set; }
        public virtual TbLojaEspecialSecao IdLojaEspecialSecaoNavigation { get; set; }
        public virtual TbProduto IdProdutoNavigation { get; set; }
    }
}
