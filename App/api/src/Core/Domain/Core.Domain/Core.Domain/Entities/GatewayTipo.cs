using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class GatewayTipo
    {
        public GatewayTipo()
        {
            Gateway = new HashSet<Gateway>();
            GatewayTipoFormaPagamento = new HashSet<GatewayTipoFormaPagamento>();
        }

        public int IdGatewayTipo { get; set; }
        public string DsGatewayTipo { get; set; }

        public virtual ICollection<Gateway> Gateway { get; set; }
        public virtual ICollection<GatewayTipoFormaPagamento> GatewayTipoFormaPagamento { get; set; }
    }
}
