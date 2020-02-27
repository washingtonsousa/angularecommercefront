using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbPromocaoBeneficio
    {
        public TbPromocaoBeneficio()
        {
            TbPromocao = new HashSet<TbPromocao>();
            TbPromocaoTipoBeneficio = new HashSet<TbPromocaoTipoBeneficio>();
        }

        public int IdPromocaoBeneficio { get; set; }
        public string NmPromocaoBeneficio { get; set; }

        public virtual ICollection<TbPromocao> TbPromocao { get; set; }
        public virtual ICollection<TbPromocaoTipoBeneficio> TbPromocaoTipoBeneficio { get; set; }
    }
}
