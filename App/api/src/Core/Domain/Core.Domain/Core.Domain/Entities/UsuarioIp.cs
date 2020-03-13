using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class UsuarioIp
    {
        public int IdUsuarioIp { get; set; }
        public int IdUsuario { get; set; }
        public string DsIp { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
