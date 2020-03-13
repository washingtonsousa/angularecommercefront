using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PromocaoCategoria
    {
        public int IdPromocaoCategoria { get; set; }
        public int IdPromocao { get; set; }
        public int IdDepartamento { get; set; }
        public int? IdSecao { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdSubcategoria { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Categoria IdDepartamentoNavigation { get; set; }
        public virtual Promocao IdPromocaoNavigation { get; set; }
        public virtual Categoria IdSecaoNavigation { get; set; }
        public virtual Categoria IdSubcategoriaNavigation { get; set; }
    }
}
