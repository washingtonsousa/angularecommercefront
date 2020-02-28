using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbPagamentoGateway
    {
        public int IdPagamentoGateway { get; set; }
        public int IdPagamento { get; set; }
        public int IdGateway { get; set; }

        public virtual TbGateway IdGatewayNavigation { get; set; }
        public virtual TbPagamento IdPagamentoNavigation { get; set; }
    }
}
