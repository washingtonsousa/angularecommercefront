using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbFiltroTipo
    {
        public TbFiltroTipo()
        {
            TbFiltro = new HashSet<TbFiltro>();
            TbFiltroTipoCategoria = new HashSet<TbFiltroTipoCategoria>();
        }

        public int IdFiltroTipo { get; set; }
        public bool FlStatus { get; set; }
        public string NmFiltroTipo { get; set; }
        public string CdExterno { get; set; }

        public virtual ICollection<TbFiltro> TbFiltro { get; set; }
        public virtual ICollection<TbFiltroTipoCategoria> TbFiltroTipoCategoria { get; set; }
    }
}
