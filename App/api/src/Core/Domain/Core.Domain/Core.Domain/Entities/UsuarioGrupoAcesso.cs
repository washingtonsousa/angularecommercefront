using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class UsuarioGrupoAcesso
    {
        public int IdUsuarioGrupoAcesso { get; set; }
        public int IdUsuarioGrupo { get; set; }
        public int IdAcesso { get; set; }
        public bool FlInclui { get; set; }
        public bool FlAltera { get; set; }
        public bool FlExclui { get; set; }
        public bool FlConsulta { get; set; }

        public virtual Acesso IdAcessoNavigation { get; set; }
        public virtual UsuarioGrupo IdUsuarioGrupoNavigation { get; set; }
    }
}
