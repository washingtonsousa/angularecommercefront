using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class GatewayTipoFormaPagamento
    {
        public int IdGatewayTipoFormaPagamento { get; set; }
        public int IdGatewayTipo { get; set; }
        public int IdFormaPagamento { get; set; }

        public virtual FormaPagamento IdFormaPagamentoNavigation { get; set; }
        public virtual GatewayTipo IdGatewayTipoNavigation { get; set; }
    }
}
