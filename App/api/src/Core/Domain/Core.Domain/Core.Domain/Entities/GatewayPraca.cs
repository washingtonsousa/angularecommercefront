using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class GatewayPraca
    {
        public int IdGatewayPraca { get; set; }
        public int IdGateway { get; set; }
        public int IdPraca { get; set; }

        public virtual Gateway IdGatewayNavigation { get; set; }
        public virtual Praca IdPracaNavigation { get; set; }
    }
}
