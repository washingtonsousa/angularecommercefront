using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbProdutoCategoria
    {
        public int IdProdutoCategoria { get; set; }
        public int IdProduto { get; set; }
        public int IdDepartamento { get; set; }
        public int IdSecao { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdSubcategoria { get; set; }
        public bool? FlPrincipal { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Categoria IdDepartamentoNavigation { get; set; }
        public virtual TbProduto IdProdutoNavigation { get; set; }
        public virtual Categoria IdSecaoNavigation { get; set; }
        public virtual Categoria IdSubcategoriaNavigation { get; set; }
    }
}
