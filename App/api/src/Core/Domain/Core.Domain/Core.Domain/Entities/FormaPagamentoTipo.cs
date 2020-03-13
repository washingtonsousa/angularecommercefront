using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class FormaPagamentoTipo
    {
        public FormaPagamentoTipo()
        {
            FormaPagamento = new HashSet<FormaPagamento>();
        }

        public int IdFormaPagamentoTipo { get; set; }
        public string NmFormaPagamentoTipo { get; set; }

        public virtual ICollection<FormaPagamento> FormaPagamento { get; set; }
    }
}
