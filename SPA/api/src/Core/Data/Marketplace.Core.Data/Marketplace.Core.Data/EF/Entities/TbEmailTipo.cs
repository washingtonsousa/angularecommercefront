using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbEmailTipo
    {
        public TbEmailTipo()
        {
            TbEmail = new HashSet<TbEmail>();
        }

        public int IdEmailTipo { get; set; }
        public string DsEmailTipo { get; set; }

        public virtual ICollection<TbEmail> TbEmail { get; set; }
    }
}
