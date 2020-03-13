using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class LogProcedure
    {
        public int IdLog { get; set; }
        public string DsLog { get; set; }
        public DateTime DtLog { get; set; }
    }
}
