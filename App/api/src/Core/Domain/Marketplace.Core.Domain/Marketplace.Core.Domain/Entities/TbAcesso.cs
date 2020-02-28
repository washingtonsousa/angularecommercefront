using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbAcesso
    {
        public TbAcesso()
        {
            TbUsuarioGrupoAcesso = new HashSet<TbUsuarioGrupoAcesso>();
        }

        public int IdAcesso { get; set; }
        public string DsAcesso { get; set; }

        public virtual ICollection<TbUsuarioGrupoAcesso> TbUsuarioGrupoAcesso { get; set; }
    }
}
