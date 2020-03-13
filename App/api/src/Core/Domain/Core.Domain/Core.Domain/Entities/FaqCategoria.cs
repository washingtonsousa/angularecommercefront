using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class FaqCategoria
    {
        public FaqCategoria()
        {
            Faq = new HashSet<Faq>();
        }

        public int IdFaqCategoria { get; set; }
        public bool FlStatus { get; set; }
        public string NmFaqCategoria { get; set; }

        public virtual ICollection<Faq> Faq { get; set; }
    }
}
