using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbModalidadeEntregaCep
    {
        public int IdModalidadeEntregaCep { get; set; }
        public int IdModalidadeEntrega { get; set; }
        public int NuPrazoEntrega { get; set; }
        public decimal NuPesoInicial { get; set; }
        public decimal NuPesoFinal { get; set; }
        public decimal VlFrete { get; set; }
        public decimal? VlAdicionalGrama { get; set; }
        public string DsCepInicial { get; set; }
        public string DsCepFinal { get; set; }
        public string DsMensagem { get; set; }
        public string DsEstado { get; set; }
        public string DsCidade { get; set; }
        public string DsBairro { get; set; }

        public virtual TbModalidadeEntrega IdModalidadeEntregaNavigation { get; set; }
    }
}
