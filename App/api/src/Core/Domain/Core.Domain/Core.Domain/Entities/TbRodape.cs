using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbRodape
    {
        public int IdRodape { get; set; }
        public int IdPraca { get; set; }
        public string NmRodape { get; set; }
        public string TxConteudo { get; set; }

        public virtual Praca IdPracaNavigation { get; set; }
    }
}
