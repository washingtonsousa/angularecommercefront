using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbPromocaoCupomUtilizado
    {
        public int IdPromocaoCupomUtilizado { get; set; }
        public int IdPromocaoCupom { get; set; }
        public int? IdCliente { get; set; }
        public DateTime DtUtilizado { get; set; }
        public int IdPedido { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; }
        public virtual TbPedido IdPedidoNavigation { get; set; }
        public virtual TbPromocaoCupom IdPromocaoCupomNavigation { get; set; }
    }
}
