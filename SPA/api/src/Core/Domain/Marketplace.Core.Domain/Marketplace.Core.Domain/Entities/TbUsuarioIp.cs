using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbUsuarioIp
    {
        public int IdUsuarioIp { get; set; }
        public int IdUsuario { get; set; }
        public string DsIp { get; set; }

        public virtual TbUsuario IdUsuarioNavigation { get; set; }
    }
}
