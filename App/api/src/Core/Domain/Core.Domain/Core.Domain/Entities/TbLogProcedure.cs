using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbLogProcedure
    {
        public int IdLog { get; set; }
        public string DsLog { get; set; }
        public DateTime DtLog { get; set; }
    }
}
