using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
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

        public virtual TbCategoria IdCategoriaNavigation { get; set; }
        public virtual TbCategoria IdDepartamentoNavigation { get; set; }
        public virtual TbProduto IdProdutoNavigation { get; set; }
        public virtual TbCategoria IdSecaoNavigation { get; set; }
        public virtual TbCategoria IdSubcategoriaNavigation { get; set; }
    }
}
