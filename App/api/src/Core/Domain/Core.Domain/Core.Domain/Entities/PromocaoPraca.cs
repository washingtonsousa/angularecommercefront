using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PromocaoPraca
    {
        public int IdPromocaoPraca { get; set; }
        public int IdPromocao { get; set; }
        public int IdPraca { get; set; }

        public virtual Praca IdPracaNavigation { get; set; }
        public virtual Promocao IdPromocaoNavigation { get; set; }
    }
}
