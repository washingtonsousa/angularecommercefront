using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class FiltroTipoCategoria
    {
        public int IdFiltroTipoCategoria { get; set; }
        public int IdFiltroTipo { get; set; }
        public int IdDepartamento { get; set; }
        public int IdSecao { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdSubcategoria { get; set; }

        public virtual FiltroTipo IdFiltroTipoNavigation { get; set; }
    }
}
