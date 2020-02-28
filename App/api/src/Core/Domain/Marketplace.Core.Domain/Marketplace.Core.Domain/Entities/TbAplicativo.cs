using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbAplicativo
    {
        public TbAplicativo()
        {
            TbAcessoAplicativo = new HashSet<TbAcessoAplicativo>();
            TbGraficoCockpit = new HashSet<TbGraficoCockpit>();
        }

        public int IdAplicativo { get; set; }
        public string NmAplicativo { get; set; }
        public string DsAplicativo { get; set; }
        public bool? FlGraficoDefault { get; set; }

        public virtual ICollection<TbAcessoAplicativo> TbAcessoAplicativo { get; set; }
        public virtual ICollection<TbGraficoCockpit> TbGraficoCockpit { get; set; }
    }
}
