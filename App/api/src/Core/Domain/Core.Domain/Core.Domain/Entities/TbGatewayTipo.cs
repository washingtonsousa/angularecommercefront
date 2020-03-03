using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbGatewayTipo
    {
        public TbGatewayTipo()
        {
            TbGateway = new HashSet<TbGateway>();
            TbGatewayTipoFormaPagamento = new HashSet<TbGatewayTipoFormaPagamento>();
        }

        public int IdGatewayTipo { get; set; }
        public string DsGatewayTipo { get; set; }

        public virtual ICollection<TbGateway> TbGateway { get; set; }
        public virtual ICollection<TbGatewayTipoFormaPagamento> TbGatewayTipoFormaPagamento { get; set; }
    }
}
