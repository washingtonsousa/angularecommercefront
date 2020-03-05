using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbPagamento
    {
        public TbPagamento()
        {
            TbPagamentoGateway = new HashSet<TbPagamentoGateway>();
            TbPagamentoParcela = new HashSet<TbPagamentoParcela>();
            TbPedidoPagamento = new HashSet<PedidoPagamento>();
        }

        public int IdPagamento { get; set; }
        public int IdFormaPagamento { get; set; }
        public string NmPagamento { get; set; }
        public bool FlStatus { get; set; }
        public int NuVencimentoPagamento { get; set; }
        public string DsInstrucaoPagamento { get; set; }
        public decimal VlTrocoMaximo { get; set; }

        public virtual TbFormaPagamento IdFormaPagamentoNavigation { get; set; }
        public virtual ICollection<TbPagamentoGateway> TbPagamentoGateway { get; set; }
        public virtual ICollection<TbPagamentoParcela> TbPagamentoParcela { get; set; }
        public virtual ICollection<PedidoPagamento> TbPedidoPagamento { get; set; }
    }
}
