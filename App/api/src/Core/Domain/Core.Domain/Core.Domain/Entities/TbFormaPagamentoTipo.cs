using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbFormaPagamentoTipo
    {
        public TbFormaPagamentoTipo()
        {
            TbFormaPagamento = new HashSet<TbFormaPagamento>();
        }

        public int IdFormaPagamentoTipo { get; set; }
        public string NmFormaPagamentoTipo { get; set; }

        public virtual ICollection<TbFormaPagamento> TbFormaPagamento { get; set; }
    }
}
