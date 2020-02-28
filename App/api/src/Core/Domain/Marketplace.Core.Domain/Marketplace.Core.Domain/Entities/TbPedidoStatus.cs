using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbPedidoStatus
    {
        public TbPedidoStatus()
        {
            TbEmail = new HashSet<TbEmail>();
            TbPedidoLogIdPedidoStatusAnteriorNavigation = new HashSet<TbPedidoLog>();
            TbPedidoLogIdPedidoStatusAtualNavigation = new HashSet<TbPedidoLog>();
        }

        public int IdPedidoStatus { get; set; }
        public string CdExterno { get; set; }
        public string NmPedidoStatus { get; set; }
        public bool FlVendido { get; set; }

        public virtual ICollection<TbEmail> TbEmail { get; set; }
        public virtual ICollection<TbPedidoLog> TbPedidoLogIdPedidoStatusAnteriorNavigation { get; set; }
        public virtual ICollection<TbPedidoLog> TbPedidoLogIdPedidoStatusAtualNavigation { get; set; }
    }
}
