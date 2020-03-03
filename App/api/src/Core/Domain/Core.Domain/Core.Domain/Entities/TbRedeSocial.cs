using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbRedeSocial
    {
        public int IdRedeSocial { get; set; }
        public string NmRedeSocial { get; set; }
        public string DsLink { get; set; }
        public string DsLogo { get; set; }
        public string TxPlugin { get; set; }
    }
}
