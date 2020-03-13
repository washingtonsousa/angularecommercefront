using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Gateway
    {
        public Gateway()
        {
            GatewayPraca = new HashSet<GatewayPraca>();
            PagamentoGateway = new HashSet<PagamentoGateway>();
        }

        public int IdGateway { get; set; }
        public int IdGatewayTipo { get; set; }
        public string DsNome { get; set; }
        public string DsMerchantId { get; set; }
        public string DsMerchantKey { get; set; }
        public bool FlClearsale { get; set; }
        public bool FlStatus { get; set; }
        public bool FlProducao { get; set; }

        public virtual GatewayTipo IdGatewayTipoNavigation { get; set; }
        public virtual ICollection<GatewayPraca> GatewayPraca { get; set; }
        public virtual ICollection<PagamentoGateway> PagamentoGateway { get; set; }
    }
}
