using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class SecLogged
    {
        public string Login { get; set; }
        public int? DateLogin { get; set; }
        public string ScSession { get; set; }
    }
}
