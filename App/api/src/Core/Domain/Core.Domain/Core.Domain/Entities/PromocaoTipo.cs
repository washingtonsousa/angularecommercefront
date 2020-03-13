using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PromocaoTipo
    {
        public PromocaoTipo()
        {
            Promocao = new HashSet<Promocao>();
            PromocaoTipoAcao = new HashSet<PromocaoTipoAcao>();
            PromocaoTipoBeneficio = new HashSet<PromocaoTipoBeneficio>();
        }

        public int IdPromocaoTipo { get; set; }
        public string NmPromocaoTipo { get; set; }

        public virtual ICollection<Promocao> Promocao { get; set; }
        public virtual ICollection<PromocaoTipoAcao> PromocaoTipoAcao { get; set; }
        public virtual ICollection<PromocaoTipoBeneficio> PromocaoTipoBeneficio { get; set; }
    }
}
