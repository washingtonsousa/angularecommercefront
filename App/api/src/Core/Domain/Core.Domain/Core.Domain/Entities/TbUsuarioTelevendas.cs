using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbUsuarioTelevendas
    {
        public TbUsuarioTelevendas()
        {
            TbLogTelevendas = new HashSet<TbLogTelevendas>();
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

        public virtual TbUsuarioGrupoTelevendas IdUsuarioGrupoTelevendasNavigation { get; set; }
        public virtual ICollection<TbLogTelevendas> TbLogTelevendas { get; set; }
    }
}
