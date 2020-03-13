using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Acesso
    {
        public Acesso()
        {
            UsuarioGrupoAcesso = new HashSet<UsuarioGrupoAcesso>();
        }

        public int IdAcesso { get; set; }
        public string DsAcesso { get; set; }

        public virtual ICollection<UsuarioGrupoAcesso> UsuarioGrupoAcesso { get; set; }
    }
}
