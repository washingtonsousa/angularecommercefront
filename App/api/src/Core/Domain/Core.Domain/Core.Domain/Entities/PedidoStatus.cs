using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PedidoStatus
    {
        public PedidoStatus()
        {
            Email = new HashSet<Email>();
            PedidoLogIdPedidoStatusAnteriorNavigation = new HashSet<PedidoLog>();
            PedidoLogIdPedidoStatusAtualNavigation = new HashSet<PedidoLog>();
        }

        public int IdPedidoStatus { get; set; }
        public string CdExterno { get; set; }
        public string NmPedidoStatus { get; set; }
        public bool FlVendido { get; set; }

        public virtual ICollection<Email> Email { get; set; }
        public virtual ICollection<PedidoLog> PedidoLogIdPedidoStatusAnteriorNavigation { get; set; }
        public virtual ICollection<PedidoLog> PedidoLogIdPedidoStatusAtualNavigation { get; set; }
    }
}
