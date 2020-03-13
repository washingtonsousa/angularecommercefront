using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class AuditFrete
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
