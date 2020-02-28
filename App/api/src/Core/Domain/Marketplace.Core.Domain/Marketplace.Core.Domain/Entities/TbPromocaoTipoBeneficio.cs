using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbPromocaoTipoBeneficio
    {
        public int IdPromocaoTipoBeneficio { get; set; }
        public int IdPromocaoTipo { get; set; }
        public int IdPromocaoBeneficio { get; set; }

        public virtual TbPromocaoBeneficio IdPromocaoBeneficioNavigation { get; set; }
        public virtual TbPromocaoTipo IdPromocaoTipoNavigation { get; set; }
    }
}
