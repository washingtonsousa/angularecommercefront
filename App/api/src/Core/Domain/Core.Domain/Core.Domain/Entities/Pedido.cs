using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Pedido
    {
        public Pedido()
        {
            PedidoEntrega = new HashSet<PedidoEntrega>();
            PedidoHistorico = new HashSet<PedidoHistorico>();
            PedidoLog = new HashSet<PedidoLog>();
            PedidoPagamento = new HashSet<PedidoPagamento>();
            PedidoPagamentoLog = new HashSet<PedidoPagamentoLog>();
            PedidoProdutosSku = new HashSet<PedidoProdutoSku>();
            PedidoSevenpdv = new HashSet<PedidoSevenpdv>();
            PromocaoCupomUtilizado = new HashSet<PromocaoCupomUtilizado>();
        }

        public int IdPedido { get; set; }
        public int IdPedidoOrigem { get; set; }
        public int IdPedidoStatus { get; set; }
        public int? IdParceiro { get; set; }
        public int? IdModalidadeEntrega { get; set; }
        public int? IdCliente { get; set; }
        public int? IdUsuarioTelevendas { get; set; }
        public bool? FlNfPaulista { get; set; }
        public string NuPedido { get; set; }
        public int? NuPrazoEntrega { get; set; }
        public DateTime DtPedido { get; set; }
        public DateTime DtExpiracao { get; set; }
        public decimal VlTotal { get; set; }
        public decimal? VlFrete { get; set; }
        public decimal? VlDesconto { get; set; }
        public string DsNavegador { get; set; }
        public string DsIp { get; set; }
        public string DsCep { get; set; }
        public string CdRastreamento { get; set; }
        public string DsDescricao { get; set; }
        public string CdVendedor { get; set; }
        public string FlIntegracao { get; set; }
        public decimal? VlDescontoFrete { get; set; }
        public bool FlRetornoEstoque { get; set; }
        public string DsMensagemEntrega { get; set; }
        public string NmModalidadeEntrega { get; set; }
        public int? IdPraca { get; set; }
        public decimal? VlDescontoCarrinho { get; set; }
        public decimal? VlDescontoPagamento { get; set; }
        public decimal? VlDescontoProduto { get; set; }
        public decimal? VlDescontoCupom { get; set; }
        public decimal? VlDescontoPrimeiraCompra { get; set; }
        public decimal? VlDescontoCliente { get; set; }
        public string DsFingerPrintSessionId { get; set; }
        public string DsStatusAntifraude { get; set; }
        public long NrCupomFiscal { get; set; }
        public long NrCentralPbm { get; set; }
        public string CdAdministradoraPbm { get; set; }
        public long NrCpfclientePbm { get; set; }
        public long NrCartaoclientePbm { get; set; }
        public string DsComprovantePbm { get; set; }
        public int? IdPedidoStatusPbm { get; set; }
        public bool? FlMarketingCarrinhoVerificado { get; set; }
        public bool? FlImpresso { get; set; }

        public virtual ICollection<PedidoEntrega> PedidoEntrega { get; set; }
        public virtual ICollection<PedidoHistorico> PedidoHistorico { get; set; }
        public virtual ICollection<PedidoLog> PedidoLog { get; set; }
        public virtual ICollection<PedidoPagamento> PedidoPagamento { get; set; }
        public virtual ICollection<PedidoPagamentoLog> PedidoPagamentoLog { get; set; }
        public virtual ICollection<PedidoProdutoSku> PedidoProdutosSku { get; set; }
        public virtual ICollection<PedidoSevenpdv> PedidoSevenpdv { get; set; }
        public virtual ICollection<PromocaoCupomUtilizado> PromocaoCupomUtilizado { get; set; }
    }
}
