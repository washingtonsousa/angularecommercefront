using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PromocaoBeneficio
    {
        public PromocaoBeneficio()
        {
            Promocao = new HashSet<Promocao>();
            PromocaoTipoBeneficio = new HashSet<PromocaoTipoBeneficio>();
        }

        public int IdPromocaoBeneficio { get; set; }
        public string NmPromocaoBeneficio { get; set; }

        public virtual ICollection<Promocao> Promocao { get; set; }
        public virtual ICollection<PromocaoTipoBeneficio> PromocaoTipoBeneficio { get; set; }
    }
}
