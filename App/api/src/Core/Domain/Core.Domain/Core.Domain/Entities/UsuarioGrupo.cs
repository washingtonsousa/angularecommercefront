using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class UsuarioGrupo
    {
        public UsuarioGrupo()
        {
            Usuario = new HashSet<Usuario>();
            UsuarioGrupoAcesso = new HashSet<UsuarioGrupoAcesso>();
        }

        public int IdUsuarioGrupo { get; set; }
        public bool FlStatus { get; set; }
        public DateTime DtCadastro { get; set; }
        public string NmUsuarioGrupo { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
        public virtual ICollection<UsuarioGrupoAcesso> UsuarioGrupoAcesso { get; set; }
    }
}
