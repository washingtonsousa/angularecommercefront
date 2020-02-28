using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbPromocaoPraca
    {
        public int IdPromocaoPraca { get; set; }
        public int IdPromocao { get; set; }
        public int IdPraca { get; set; }

        public virtual TbPraca IdPracaNavigation { get; set; }
        public virtual TbPromocao IdPromocaoNavigation { get; set; }
    }
}
