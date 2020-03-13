using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ListaDesejoPeriodo
    {
        public ListaDesejoPeriodo()
        {
            ListaDesejo = new HashSet<ListaDesejo>();
        }

        public int IdListaDesejoPeriodo { get; set; }
        public bool FlStatus { get; set; }
        public int NuPeriodo { get; set; }
        public string DsListaDesejoPeriodo { get; set; }

        public virtual ICollection<ListaDesejo> ListaDesejo { get; set; }
    }
}
