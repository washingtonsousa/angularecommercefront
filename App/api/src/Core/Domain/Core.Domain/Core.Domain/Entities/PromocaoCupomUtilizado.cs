using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PromocaoCupomUtilizado
    {
        public int IdPromocaoCupomUtilizado { get; set; }
        public int IdPromocaoCupom { get; set; }
        public int? IdCliente { get; set; }
        public DateTime DtUtilizado { get; set; }
        public int IdPedido { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Pedido IdPedidoNavigation { get; set; }
        public virtual PromocaoCupom IdPromocaoCupomNavigation { get; set; }
    }
}
