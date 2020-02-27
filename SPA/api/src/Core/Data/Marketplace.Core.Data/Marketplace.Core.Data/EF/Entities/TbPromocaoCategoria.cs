using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbPromocaoCategoria
    {
        public int IdPromocaoCategoria { get; set; }
        public int IdPromocao { get; set; }
        public int IdDepartamento { get; set; }
        public int? IdSecao { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdSubcategoria { get; set; }

        public virtual TbCategoria IdCategoriaNavigation { get; set; }
        public virtual TbCategoria IdDepartamentoNavigation { get; set; }
        public virtual TbPromocao IdPromocaoNavigation { get; set; }
        public virtual TbCategoria IdSecaoNavigation { get; set; }
        public virtual TbCategoria IdSubcategoriaNavigation { get; set; }
    }
}
