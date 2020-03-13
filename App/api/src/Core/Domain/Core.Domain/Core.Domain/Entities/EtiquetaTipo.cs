using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class EtiquetaTipo
    {
        public EtiquetaTipo()
        {
            Etiqueta = new HashSet<Etiqueta>();
        }

        public int IdEtiquetaTipo { get; set; }
        public string NmEtiquetaTipo { get; set; }

        public virtual ICollection<Etiqueta> Etiqueta { get; set; }
    }
}
