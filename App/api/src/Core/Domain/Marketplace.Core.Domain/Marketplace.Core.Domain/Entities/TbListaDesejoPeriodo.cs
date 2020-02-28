using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbListaDesejoPeriodo
    {
        public TbListaDesejoPeriodo()
        {
            TbListaDesejo = new HashSet<TbListaDesejo>();
        }

        public int IdListaDesejoPeriodo { get; set; }
        public bool FlStatus { get; set; }
        public int NuPeriodo { get; set; }
        public string DsListaDesejoPeriodo { get; set; }

        public virtual ICollection<TbListaDesejo> TbListaDesejo { get; set; }
    }
}
