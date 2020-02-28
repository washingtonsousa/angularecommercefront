using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbPedidoPagamentoLog
    {
        public int IdPedidoPagamentoLog { get; set; }
        public int IdPedido { get; set; }
        public string DsMensagem { get; set; }
        public DateTime? DtLog { get; set; }
        public string XmlEnvio { get; set; }
        public string XmlRetorno { get; set; }

        public virtual TbPedido IdPedidoNavigation { get; set; }
    }
}
