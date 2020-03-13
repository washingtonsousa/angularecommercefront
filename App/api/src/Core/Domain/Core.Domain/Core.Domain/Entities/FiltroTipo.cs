using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class FiltroTipo
    {
        public FiltroTipo()
        {
            Filtro = new HashSet<Filtro>();
            FiltroTipoCategoria = new HashSet<FiltroTipoCategoria>();
        }

        public int IdFiltroTipo { get; set; }
        public bool FlStatus { get; set; }
        public string NmFiltroTipo { get; set; }
        public string CdExterno { get; set; }

        public virtual ICollection<Filtro> Filtro { get; set; }
        public virtual ICollection<FiltroTipoCategoria> FiltroTipoCategoria { get; set; }
    }
}
