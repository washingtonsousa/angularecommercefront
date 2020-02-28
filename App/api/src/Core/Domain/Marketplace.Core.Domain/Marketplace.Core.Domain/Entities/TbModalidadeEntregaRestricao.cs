using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbModalidadeEntregaRestricao
    {
        public int IdModalidadeEntregaRestricao { get; set; }
        public int IdModalidadeEntrega { get; set; }
        public bool FlAtende { get; set; }
        public decimal? PcAcrescimoTarifa { get; set; }
        public string DsMensagem { get; set; }
        public string DsCepInicial { get; set; }
        public string DsCepFinal { get; set; }
        public int? NuHorasAcrescimo { get; set; }
        public bool FlConsideraHorario { get; set; }
        public DateTime? NuHorarioInicial { get; set; }
        public DateTime? NuHorarioFinal { get; set; }

        public virtual TbModalidadeEntrega IdModalidadeEntregaNavigation { get; set; }
    }
}
