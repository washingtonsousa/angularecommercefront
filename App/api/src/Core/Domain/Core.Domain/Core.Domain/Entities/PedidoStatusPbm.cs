using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PedidoStatusPbm
    {
        public int IdPedidoStatusPbm { get; set; }
        public int? IdAutorizador { get; set; }
        public int CdExterno { get; set; }
        public string DsDescricao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public DateTime? DtAlteracao { get; set; }
    }
}
