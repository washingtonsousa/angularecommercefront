using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbUsuarioGrupo
    {
        public TbUsuarioGrupo()
        {
            TbUsuario = new HashSet<TbUsuario>();
            TbUsuarioGrupoAcesso = new HashSet<TbUsuarioGrupoAcesso>();
        }

        public int IdUsuarioGrupo { get; set; }
        public bool FlStatus { get; set; }
        public DateTime DtCadastro { get; set; }
        public string NmUsuarioGrupo { get; set; }

        public virtual ICollection<TbUsuario> TbUsuario { get; set; }
        public virtual ICollection<TbUsuarioGrupoAcesso> TbUsuarioGrupoAcesso { get; set; }
    }
}
