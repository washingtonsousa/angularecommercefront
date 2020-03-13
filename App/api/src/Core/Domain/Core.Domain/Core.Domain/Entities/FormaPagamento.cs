using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class FormaPagamento
    {
        public FormaPagamento()
        {
            GatewayTipoFormaPagamento = new HashSet<GatewayTipoFormaPagamento>();
            Pagamento = new HashSet<Pagamento>();
            PromocaoPagamento = new HashSet<PromocaoPagamento>();
        }

        public int IdFormaPagamento { get; set; }
        public string NmFormaPagamento { get; set; }
        public int IdFormaPagamentoTipo { get; set; }
        public string DsLogo { get; set; }

        public virtual FormaPagamentoTipo IdFormaPagamentoTipoNavigation { get; set; }
        public virtual ICollection<GatewayTipoFormaPagamento> GatewayTipoFormaPagamento { get; set; }
        public virtual ICollection<Pagamento> Pagamento { get; set; }
        public virtual ICollection<PromocaoPagamento> PromocaoPagamento { get; set; }
    }
}
