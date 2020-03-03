using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbGateway
    {
        public TbGateway()
        {
            TbGatewayPraca = new HashSet<TbGatewayPraca>();
            TbPagamentoGateway = new HashSet<TbPagamentoGateway>();
        }

        public int IdGateway { get; set; }
        public int IdGatewayTipo { get; set; }
        public string DsNome { get; set; }
        public string DsMerchantId { get; set; }
        public string DsMerchantKey { get; set; }
        public bool FlClearsale { get; set; }
        public bool FlStatus { get; set; }
        public bool FlProducao { get; set; }

        public virtual TbGatewayTipo IdGatewayTipoNavigation { get; set; }
        public virtual ICollection<TbGatewayPraca> TbGatewayPraca { get; set; }
        public virtual ICollection<TbPagamentoGateway> TbPagamentoGateway { get; set; }
    }
}
