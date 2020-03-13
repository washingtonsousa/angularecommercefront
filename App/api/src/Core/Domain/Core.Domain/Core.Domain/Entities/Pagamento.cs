using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Pagamento
    {
        public Pagamento()
        {
            PagamentoGateway = new HashSet<PagamentoGateway>();
            PagamentoParcela = new HashSet<PagamentoParcela>();
            PedidoPagamento = new HashSet<PedidoPagamento>();
        }

        public int IdPagamento { get; set; }
        public int IdFormaPagamento { get; set; }
        public string NmPagamento { get; set; }
        public bool FlStatus { get; set; }
        public int NuVencimentoPagamento { get; set; }
        public string DsInstrucaoPagamento { get; set; }
        public decimal VlTrocoMaximo { get; set; }

        public virtual FormaPagamento IdFormaPagamentoNavigation { get; set; }
        public virtual ICollection<PagamentoGateway> PagamentoGateway { get; set; }
        public virtual ICollection<PagamentoParcela> PagamentoParcela { get; set; }
        public virtual ICollection<PedidoPagamento> PedidoPagamento { get; set; }
    }
}
