﻿using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PedidoHistorico
    {
        public int IdPedidoHistorico { get; set; }
        public int IdPedido { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtCadastro { get; set; }
        public string DsHistorico { get; set; }

        public virtual Pedido IdPedidoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
