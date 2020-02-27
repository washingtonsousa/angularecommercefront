using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbPromocaoAcao
    {
        public TbPromocaoAcao()
        {
            TbPromocao = new HashSet<TbPromocao>();
            TbPromocaoTipoAcao = new HashSet<TbPromocaoTipoAcao>();
        }

        public int IdPromocaoAcao { get; set; }
        public string NmPromocaoAcao { get; set; }

        public virtual ICollection<TbPromocao> TbPromocao { get; set; }
        public virtual ICollection<TbPromocaoTipoAcao> TbPromocaoTipoAcao { get; set; }
    }
}
