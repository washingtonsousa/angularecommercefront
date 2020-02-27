using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbVitrinePraca
    {
        public int IdVitrinePraca { get; set; }
        public int IdVitrine { get; set; }
        public int IdPraca { get; set; }

        public virtual TbPraca IdPracaNavigation { get; set; }
        public virtual TbVitrine IdVitrineNavigation { get; set; }
    }
}
