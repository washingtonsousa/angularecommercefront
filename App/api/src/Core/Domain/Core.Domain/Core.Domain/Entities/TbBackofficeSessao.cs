using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbBackofficeSessao
    {
        public string IdSessao { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtAtualizacao { get; set; }

        public virtual TbUsuario IdUsuarioNavigation { get; set; }
    }
}
