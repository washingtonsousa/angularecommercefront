using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PedidoEntrega
    {
        public int IdPedidoEntrega { get; set; }
        public int IdPedido { get; set; }
        public string DsCep { get; set; }
        public string DsEndereco { get; set; }
        public string NuEndereco { get; set; }
        public string DsComplemento { get; set; }
        public string DsReferencia { get; set; }
        public string DsBairro { get; set; }
        public string DsCidade { get; set; }
        public string DsEstado { get; set; }
        public string DsDestinatario { get; set; }
        public int? IdClienteEndereco { get; set; }
        public string NmTipoEndereco { get; set; }

        public virtual Pedido IdPedidoNavigation { get; set; }
    }
}
