using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbUsuarioGrupoTelevendas
    {
        public TbUsuarioGrupoTelevendas()
        {
            TbUsuarioTelevendas = new HashSet<TbUsuarioTelevendas>();
        }

        public int IdUsuarioGrupoTelevendas { get; set; }
        public string NmUsuarioGrupoTelevendas { get; set; }

        public virtual ICollection<TbUsuarioTelevendas> TbUsuarioTelevendas { get; set; }
    }
}
