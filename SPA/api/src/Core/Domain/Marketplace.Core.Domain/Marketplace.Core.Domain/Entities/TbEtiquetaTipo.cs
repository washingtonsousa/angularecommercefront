using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbEtiquetaTipo
    {
        public TbEtiquetaTipo()
        {
            TbEtiqueta = new HashSet<TbEtiqueta>();
        }

        public int IdEtiquetaTipo { get; set; }
        public string NmEtiquetaTipo { get; set; }

        public virtual ICollection<TbEtiqueta> TbEtiqueta { get; set; }
    }
}
