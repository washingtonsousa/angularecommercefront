using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbFaqCategoria
    {
        public TbFaqCategoria()
        {
            TbFaq = new HashSet<TbFaq>();
        }

        public int IdFaqCategoria { get; set; }
        public bool FlStatus { get; set; }
        public string NmFaqCategoria { get; set; }

        public virtual ICollection<TbFaq> TbFaq { get; set; }
    }
}
