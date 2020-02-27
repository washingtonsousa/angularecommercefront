using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbPromocaoCupom
    {
        public TbPromocaoCupom()
        {
            TbPromocaoCupomUtilizado = new HashSet<TbPromocaoCupomUtilizado>();
        }

        public int IdPromocaoCupom { get; set; }
        public int IdPromocao { get; set; }
        public bool FlUnicoCliente { get; set; }
        public int NuQtdUtiliza { get; set; }
        public string NuCupom { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime DtValidade { get; set; }

        public virtual TbPromocao IdPromocaoNavigation { get; set; }
        public virtual ICollection<TbPromocaoCupomUtilizado> TbPromocaoCupomUtilizado { get; set; }
    }
}
