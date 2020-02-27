using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbGatewayPraca
    {
        public int IdGatewayPraca { get; set; }
        public int IdGateway { get; set; }
        public int IdPraca { get; set; }

        public virtual TbGateway IdGatewayNavigation { get; set; }
        public virtual TbPraca IdPracaNavigation { get; set; }
    }
}
