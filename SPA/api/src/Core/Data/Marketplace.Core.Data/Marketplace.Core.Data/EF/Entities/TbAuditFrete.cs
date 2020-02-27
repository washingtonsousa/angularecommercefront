using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbAuditFrete
    {
        public int IdAuditFrete { get; set; }
        public string DsQuery { get; set; }
        public DateTime? DtOcorrencia { get; set; }
        public int? IdPedido { get; set; }
        public decimal? VlFreteAnterior { get; set; }
        public decimal? VlFreteAtual { get; set; }
        public decimal? VlTotalAnterior { get; set; }
        public decimal? VlTotalAtual { get; set; }
    }
}
