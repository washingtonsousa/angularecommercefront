using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbRodape
    {
        public int IdRodape { get; set; }
        public int IdPraca { get; set; }
        public string NmRodape { get; set; }
        public string TxConteudo { get; set; }

        public virtual TbPraca IdPracaNavigation { get; set; }
    }
}
