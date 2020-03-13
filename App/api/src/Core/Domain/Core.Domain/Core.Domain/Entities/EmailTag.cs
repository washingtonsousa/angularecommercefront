using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class EmailTag
    {
        public int IdTag { get; set; }
        public string NmTag { get; set; }
        public string DsTag { get; set; }
    }
}
