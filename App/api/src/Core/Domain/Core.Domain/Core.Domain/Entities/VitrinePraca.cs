using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class VitrinePraca
    {
        public int IdVitrinePraca { get; set; }
        public int IdVitrine { get; set; }
        public int IdPraca { get; set; }

        public virtual Praca IdPracaNavigation { get; set; }
        public virtual Vitrine IdVitrineNavigation { get; set; }
    }
}
