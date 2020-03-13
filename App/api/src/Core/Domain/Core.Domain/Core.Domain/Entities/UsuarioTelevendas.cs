using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class UsuarioTelevendas
    {
        public UsuarioTelevendas()
        {
            LogTelevendas = new HashSet<LogTelevendas>();
        }

        public int IdUsuarioTelevendas { get; set; }
        public int IdUsuarioGrupoTelevendas { get; set; }
        public bool FlStatus { get; set; }
        public bool FlPrimeiroAcesso { get; set; }
        public decimal PcComissao { get; set; }
        public DateTime DtCadastro { get; set; }
        public string DsLogin { get; set; }
        public string DsSenha { get; set; }
        public string DsNome { get; set; }

        public virtual UsuarioGrupoTelevendas IdUsuarioGrupoTelevendasNavigation { get; set; }
        public virtual ICollection<LogTelevendas> LogTelevendas { get; set; }
    }
}
