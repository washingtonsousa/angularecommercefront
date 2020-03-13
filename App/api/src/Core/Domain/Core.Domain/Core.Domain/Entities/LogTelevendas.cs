using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class LogTelevendas
    {
        public int IdLogTelevendas { get; set; }
        public int IdUsuarioTelevendas { get; set; }
        public DateTime DtCadastro { get; set; }
        public string DsAcao { get; set; }

        public virtual UsuarioTelevendas IdUsuarioTelevendasNavigation { get; set; }
    }
}
