using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PromocaoCupom
    {
        public PromocaoCupom()
        {
            PromocaoCupomUtilizado = new HashSet<PromocaoCupomUtilizado>();
        }

        public int IdPromocaoCupom { get; set; }
        public int IdPromocao { get; set; }
        public bool FlUnicoCliente { get; set; }
        public int NuQtdUtiliza { get; set; }
        public string NuCupom { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime DtValidade { get; set; }

        public virtual Promocao IdPromocaoNavigation { get; set; }
        public virtual ICollection<PromocaoCupomUtilizado> PromocaoCupomUtilizado { get; set; }
    }
}
