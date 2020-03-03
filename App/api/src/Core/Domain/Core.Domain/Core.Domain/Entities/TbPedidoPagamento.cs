using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbPedidoPagamento
    {
        public int IdPedidoPagamento { get; set; }
        public int IdPedido { get; set; }
        public int IdPagamento { get; set; }
        public decimal VlParcela { get; set; }
        public int NuParcela { get; set; }
        public string NuCartao { get; set; }
        public string NmCartao { get; set; }
        public string DtValidadeCartao { get; set; }
        public string CdSeguranca { get; set; }
        public string NuBinCartao { get; set; }
        public DateTime? DtVencimento { get; set; }
        public string DsUrlBoleto { get; set; }
        public string CdBarra { get; set; }
        public string NossoNumero { get; set; }
        public string DsUrlTransferencia { get; set; }
        public decimal? VlDinheiro { get; set; }
        public decimal? VlTroco { get; set; }
        public string Nsu { get; set; }
        public string NuComprovante { get; set; }
        public string NuNit { get; set; }
        public string NuTransacao { get; set; }
        public string DsChaveTransacao { get; set; }
        public string DsChavePedido { get; set; }
        public string DsReciboCliente { get; set; }
        public string DsReciboEmpresa { get; set; }
        public string DsBandeiraMaquineta { get; set; }
        public string DsChaveCobranca { get; set; }

        public virtual TbPagamento IdPagamentoNavigation { get; set; }
        public virtual Pedido IdPedidoNavigation { get; set; }
    }
}
