using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class UsuarioPraca
    {
        public int IdUsuarioPraca { get; set; }
        public int IdUsuario { get; set; }
        public int IdPraca { get; set; }

        public virtual Praca IdPracaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
