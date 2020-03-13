using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Aplicativo
    {
        public Aplicativo()
        {
            AcessoAplicativo = new HashSet<AcessoAplicativo>();
            GraficoCockpit = new HashSet<GraficoCockpit>();
        }

        public int IdAplicativo { get; set; }
        public string NmAplicativo { get; set; }
        public string DsAplicativo { get; set; }
        public bool? FlGraficoDefault { get; set; }

        public virtual ICollection<AcessoAplicativo> AcessoAplicativo { get; set; }
        public virtual ICollection<GraficoCockpit> GraficoCockpit { get; set; }
    }
}
