using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Sli
    {
        public int IdSli { get; set; }
        public string DsFtpHost { get; set; }
        public string DsUsuario { get; set; }
        public string DsSenha { get; set; }
    }
}
