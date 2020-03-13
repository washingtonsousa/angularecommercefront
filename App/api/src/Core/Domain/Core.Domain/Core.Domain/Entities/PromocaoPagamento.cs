using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PromocaoPagamento
    {
        public int IdPromocaoPagamento { get; set; }
        public int IdPromocao { get; set; }
        public int? IdFormaPagamento { get; set; }

        public virtual FormaPagamento IdFormaPagamentoNavigation { get; set; }
        public virtual Promocao IdPromocaoNavigation { get; set; }
    }
}
