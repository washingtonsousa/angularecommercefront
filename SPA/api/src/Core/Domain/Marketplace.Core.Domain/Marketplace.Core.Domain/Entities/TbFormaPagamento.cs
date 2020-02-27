using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbFormaPagamento
    {
        public TbFormaPagamento()
        {
            TbGatewayTipoFormaPagamento = new HashSet<TbGatewayTipoFormaPagamento>();
            TbPagamento = new HashSet<TbPagamento>();
            TbPromocaoPagamento = new HashSet<TbPromocaoPagamento>();
        }

        public int IdFormaPagamento { get; set; }
        public string NmFormaPagamento { get; set; }
        public int IdFormaPagamentoTipo { get; set; }
        public string DsLogo { get; set; }

        public virtual TbFormaPagamentoTipo IdFormaPagamentoTipoNavigation { get; set; }
        public virtual ICollection<TbGatewayTipoFormaPagamento> TbGatewayTipoFormaPagamento { get; set; }
        public virtual ICollection<TbPagamento> TbPagamento { get; set; }
        public virtual ICollection<TbPromocaoPagamento> TbPromocaoPagamento { get; set; }
    }
}
