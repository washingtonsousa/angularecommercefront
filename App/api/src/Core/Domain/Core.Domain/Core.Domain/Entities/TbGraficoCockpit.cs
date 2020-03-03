using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbGraficoCockpit
    {
        public int IdGraficoCockpit { get; set; }
        public int IdUsuario { get; set; }
        public int IdAplicativo { get; set; }
        public byte? NuOrdem { get; set; }

        public virtual TbAplicativo IdAplicativoNavigation { get; set; }
        public virtual TbUsuario IdUsuarioNavigation { get; set; }
    }
}
