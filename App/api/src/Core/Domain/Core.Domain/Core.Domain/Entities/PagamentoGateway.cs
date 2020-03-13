using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PagamentoGateway
    {
        public int IdPagamentoGateway { get; set; }
        public int IdPagamento { get; set; }
        public int IdGateway { get; set; }

        public virtual Gateway IdGatewayNavigation { get; set; }
        public virtual Pagamento IdPagamentoNavigation { get; set; }
    }
}
