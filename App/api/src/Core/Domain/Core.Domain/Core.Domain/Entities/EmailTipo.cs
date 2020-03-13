using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class EmailTipo
    {
        public EmailTipo()
        {
            Email = new HashSet<Email>();
        }

        public int IdEmailTipo { get; set; }
        public string DsEmailTipo { get; set; }

        public virtual ICollection<Email> Email { get; set; }
    }
}
