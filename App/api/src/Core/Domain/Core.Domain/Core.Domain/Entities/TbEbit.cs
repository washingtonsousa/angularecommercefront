using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbEbit
    {
        public int IdEbit { get; set; }
        public string CdEbit { get; set; }
        public string CdBuscape { get; set; }
        public bool FlAtivo { get; set; }
    }
}
