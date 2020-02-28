using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbSevenpdvSessao
    {
        public int IdSevenpdvSessao { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string DsChave { get; set; }
        public long? NuCentral { get; set; }
        public DateTime? DtCentral { get; set; }
        public string DsControleAcesso { get; set; }
        public int? CdStatusServico { get; set; }
        public string TxInformativo { get; set; }
        public string DsDesvioFluxo { get; set; }
        public string CdRetorno { get; set; }
        public int? NuHorasExpiracao { get; set; }
        public int? IdSevenpdvLogon { get; set; }

        public virtual TbSevenpdvLogon IdSevenpdvLogonNavigation { get; set; }
    }
}
