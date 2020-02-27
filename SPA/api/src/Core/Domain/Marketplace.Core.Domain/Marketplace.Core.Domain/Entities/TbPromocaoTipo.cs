using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbPromocaoTipo
    {
        public TbPromocaoTipo()
        {
            TbPromocao = new HashSet<TbPromocao>();
            TbPromocaoTipoAcao = new HashSet<TbPromocaoTipoAcao>();
            TbPromocaoTipoBeneficio = new HashSet<TbPromocaoTipoBeneficio>();
        }

        public int IdPromocaoTipo { get; set; }
        public string NmPromocaoTipo { get; set; }

        public virtual ICollection<TbPromocao> TbPromocao { get; set; }
        public virtual ICollection<TbPromocaoTipoAcao> TbPromocaoTipoAcao { get; set; }
        public virtual ICollection<TbPromocaoTipoBeneficio> TbPromocaoTipoBeneficio { get; set; }
    }
}
