﻿using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PedidoSevenpdv
    {
        public int IdPedidoSevenpdv { get; set; }
        public int IdPedido { get; set; }
        public string DsPreauth { get; set; }
        public string DsEfetiva { get; set; }
        public string DsFinaliza { get; set; }
        public bool FlEfetivado { get; set; }
        public DateTime? DtCriacao { get; set; }
        public DateTime? DtAlteracao { get; set; }

        public virtual Pedido IdPedidoNavigation { get; set; }
    }
}
