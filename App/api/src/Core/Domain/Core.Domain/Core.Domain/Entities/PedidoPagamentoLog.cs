using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PedidoPagamentoLog
    {
        public int IdPedidoPagamentoLog { get; set; }
        public int IdPedido { get; set; }
        public string DsMensagem { get; set; }
        public DateTime? DtLog { get; set; }
        public string XmlEnvio { get; set; }
        public string XmlRetorno { get; set; }

        public virtual Pedido IdPedidoNavigation { get; set; }
    }
}
