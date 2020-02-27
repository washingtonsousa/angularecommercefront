using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbMapeamentoUrl
    {
        public int IdMapeamento { get; set; }
        public string DsUrlDe { get; set; }
        public string DsUrlPara { get; set; }
        public bool FlStatus { get; set; }
        public DateTime? DtInicial { get; set; }
        public DateTime? DtFinal { get; set; }
        public int? DsResposta { get; set; }
    }
}
