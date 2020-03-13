using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PromocaoAcao
    {
        public PromocaoAcao()
        {
            Promocao = new HashSet<Promocao>();
            PromocaoTipoAcao = new HashSet<PromocaoTipoAcao>();
        }

        public int IdPromocaoAcao { get; set; }
        public string NmPromocaoAcao { get; set; }

        public virtual ICollection<Promocao> Promocao { get; set; }
        public virtual ICollection<PromocaoTipoAcao> PromocaoTipoAcao { get; set; }
    }
}
