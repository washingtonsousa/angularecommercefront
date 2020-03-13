using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PromocaoTipoBeneficio
    {
        public int IdPromocaoTipoBeneficio { get; set; }
        public int IdPromocaoTipo { get; set; }
        public int IdPromocaoBeneficio { get; set; }

        public virtual PromocaoBeneficio IdPromocaoBeneficioNavigation { get; set; }
        public virtual PromocaoTipo IdPromocaoTipoNavigation { get; set; }
    }
}
