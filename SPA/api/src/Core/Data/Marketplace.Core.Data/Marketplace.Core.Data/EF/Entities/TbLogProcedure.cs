using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbLogProcedure
    {
        public int IdLog { get; set; }
        public string DsLog { get; set; }
        public DateTime DtLog { get; set; }
    }
}
