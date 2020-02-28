using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbSli
    {
        public int IdSli { get; set; }
        public string DsFtpHost { get; set; }
        public string DsUsuario { get; set; }
        public string DsSenha { get; set; }
    }
}
