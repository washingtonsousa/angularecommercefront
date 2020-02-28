using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbPromocaoPagamento
    {
        public int IdPromocaoPagamento { get; set; }
        public int IdPromocao { get; set; }
        public int? IdFormaPagamento { get; set; }

        public virtual TbFormaPagamento IdFormaPagamentoNavigation { get; set; }
        public virtual TbPromocao IdPromocaoNavigation { get; set; }
    }
}
