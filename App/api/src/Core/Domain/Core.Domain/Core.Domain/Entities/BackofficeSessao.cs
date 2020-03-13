using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class BackofficeSessao
    {
        public string IdSessao { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtAtualizacao { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
