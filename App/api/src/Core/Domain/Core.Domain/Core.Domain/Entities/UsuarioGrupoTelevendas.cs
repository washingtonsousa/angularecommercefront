using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class UsuarioGrupoTelevendas
    {
        public UsuarioGrupoTelevendas()
        {
            UsuarioTelevendas = new HashSet<UsuarioTelevendas>();
        }

        public int IdUsuarioGrupoTelevendas { get; set; }
        public string NmUsuarioGrupoTelevendas { get; set; }

        public virtual ICollection<UsuarioTelevendas> UsuarioTelevendas { get; set; }
    }
}
