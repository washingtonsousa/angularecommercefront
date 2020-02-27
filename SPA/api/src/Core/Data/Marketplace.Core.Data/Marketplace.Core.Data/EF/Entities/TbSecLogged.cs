using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbSecLogged
    {
        public string Login { get; set; }
        public int? DateLogin { get; set; }
        public string ScSession { get; set; }
    }
}
