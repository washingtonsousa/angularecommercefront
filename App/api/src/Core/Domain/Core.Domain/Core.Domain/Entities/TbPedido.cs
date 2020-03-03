using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Pedido
    {
        public Pedido()
        {
            TbPedidoEntrega = new HashSet<TbPedidoEntrega>();
            TbPedidoHistorico = new HashSet<TbPedidoHistorico>();
            TbPedidoLog = new HashSet<TbPedidoLog>();
            TbPedidoPagamento = new HashSet<TbPedidoPagamento>();
            TbPedidoPagamentoLog = new HashSet<TbPedidoPagamentoLog>();
            TbPedidoProdutoSku = new HashSet<TbPedidoProdutoSku>();
            TbPedidoSevenpdv = new HashSet<TbPedidoSevenpdv>();
            TbPromocaoCupomUtilizado = new HashSet<TbPromocaoCupomUtilizado>();
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

        public virtual ICollection<TbPedidoEntrega> TbPedidoEntrega { get; set; }
        public virtual ICollection<TbPedidoHistorico> TbPedidoHistorico { get; set; }
        public virtual ICollection<TbPedidoLog> TbPedidoLog { get; set; }
        public virtual ICollection<TbPedidoPagamento> TbPedidoPagamento { get; set; }
        public virtual ICollection<TbPedidoPagamentoLog> TbPedidoPagamentoLog { get; set; }
        public virtual ICollection<TbPedidoProdutoSku> TbPedidoProdutoSku { get; set; }
        public virtual ICollection<TbPedidoSevenpdv> TbPedidoSevenpdv { get; set; }
        public virtual ICollection<TbPromocaoCupomUtilizado> TbPromocaoCupomUtilizado { get; set; }
    }
}
