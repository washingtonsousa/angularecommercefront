using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbAuditPedido
    {
        public int IdAuditPedido { get; set; }
        public string DsQuery { get; set; }
        public DateTime? DtOcorrencia { get; set; }
        public string Usuario { get; set; }
        public string Server { get; set; }
        public int? IdPedido { get; set; }
        public int? IdPedidoStatusNew { get; set; }
        public int? IdPedidoStatusOld { get; set; }
        public int? IdModalidadeEntregaNew { get; set; }
        public int? IdModalidadeEntregaOld { get; set; }
        public decimal? VlFreteAnterior { get; set; }
        public decimal? VlFreteAtual { get; set; }
    }
}
