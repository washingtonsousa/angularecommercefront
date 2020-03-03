using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoSku
    {
        public ProdutoSku()
        {
            TbCategoria = new HashSet<Categoria>();
            TbGondolaProdutoSku = new HashSet<TbGondolaProdutoSku>();
            TbListaDesejoProdutoSku = new HashSet<TbListaDesejoProdutoSku>();
            TbParceiroXmlProduto = new HashSet<TbParceiroXmlProduto>();
            TbPedidoProdutoKit = new HashSet<TbPedidoProdutoKit>();
            TbPedidoProdutoSku = new HashSet<TbPedidoProdutoSku>();
            TbProdutoKit = new HashSet<TbProdutoKit>();
            TbProdutoSkuAviseMe = new HashSet<TbProdutoSkuAviseMe>();
            TbProdutoSkuEspecificacao = new HashSet<TbProdutoSkuEspecificacao>();
            TbProdutoSkuFiltro = new HashSet<TbProdutoSkuFiltro>();
            TbProdutoSkuGenericoIdGenericoNavigation = new HashSet<TbProdutoSkuGenerico>();
            TbProdutoSkuGenericoIdMedicamentoNavigation = new HashSet<TbProdutoSkuGenerico>();
            TbProdutoSkuImagem = new HashSet<TbProdutoSkuImagem>();
            TbProdutoSkuPraca = new HashSet<TbProdutoSkuPraca>();
            TbProdutoSkuRelacionadoIdProdutoSkuNavigation = new HashSet<TbProdutoSkuRelacionado>();
            TbProdutoSkuRelacionadoIdProdutoSkuRelacaoNavigation = new HashSet<TbProdutoSkuRelacionado>();
            TbProdutoSkuVendaCasadaIdProdutoSkuCasadoNavigation = new HashSet<TbProdutoSkuVendaCasada>();
            TbProdutoSkuVendaCasadaIdProdutoSkuNavigation = new HashSet<TbProdutoSkuVendaCasada>();
            TbProgramaProduto = new HashSet<TbProgramaProduto>();
            TbQuemComprouComprouTambem = new HashSet<TbQuemComprouComprouTambem>();
            TbQuemViuComprouIdProdutoSkuCompradoNavigation = new HashSet<TbQuemViuComprou>();
            TbQuemViuComprouIdProdutoSkuVistoNavigation = new HashSet<TbQuemViuComprou>();
            TbQuemViuViuTambemIdProdutoSkuNavigation = new HashSet<TbQuemViuViuTambem>();
            TbQuemViuViuTambemIdProdutoSkuVistoNavigation = new HashSet<TbQuemViuViuTambem>();
            TbSuperDesconto = new HashSet<TbSuperDesconto>();
            TbVitrineProdutoSku = new HashSet<TbVitrineProdutoSku>();
        }

        public int IdProdutoSku { get; set; }
        public int IdProduto { get; set; }
        public bool FlBrinde { get; set; }
        public string CdExterno { get; set; }
        public string CdBarras { get; set; }
        public decimal NuPeso { get; set; }
        public int NuAltura { get; set; }
        public int NuLargura { get; set; }
        public int NuProfundidade { get; set; }
        public string NmProdutoSku { get; set; }
        public string CdMs { get; set; }
        public decimal? PcDescontoAtendente { get; set; }
        public DateTime? DtCadastro { get; set; }
        public bool FlExibirIndividualmente { get; set; }
        public string IdProdutoSap { get; set; }

        public virtual TbProduto IdProdutoNavigation { get; set; }
        public virtual ICollection<Categoria> TbCategoria { get; set; }
        public virtual ICollection<TbGondolaProdutoSku> TbGondolaProdutoSku { get; set; }
        public virtual ICollection<TbListaDesejoProdutoSku> TbListaDesejoProdutoSku { get; set; }
        public virtual ICollection<TbParceiroXmlProduto> TbParceiroXmlProduto { get; set; }
        public virtual ICollection<TbPedidoProdutoKit> TbPedidoProdutoKit { get; set; }
        public virtual ICollection<TbPedidoProdutoSku> TbPedidoProdutoSku { get; set; }
        public virtual ICollection<TbProdutoKit> TbProdutoKit { get; set; }
        public virtual ICollection<TbProdutoSkuAviseMe> TbProdutoSkuAviseMe { get; set; }
        public virtual ICollection<TbProdutoSkuEspecificacao> TbProdutoSkuEspecificacao { get; set; }
        public virtual ICollection<TbProdutoSkuFiltro> TbProdutoSkuFiltro { get; set; }
        public virtual ICollection<TbProdutoSkuGenerico> TbProdutoSkuGenericoIdGenericoNavigation { get; set; }
        public virtual ICollection<TbProdutoSkuGenerico> TbProdutoSkuGenericoIdMedicamentoNavigation { get; set; }
        public virtual ICollection<TbProdutoSkuImagem> TbProdutoSkuImagem { get; set; }
        public virtual ICollection<TbProdutoSkuPraca> TbProdutoSkuPraca { get; set; }
        public virtual ICollection<TbProdutoSkuRelacionado> TbProdutoSkuRelacionadoIdProdutoSkuNavigation { get; set; }
        public virtual ICollection<TbProdutoSkuRelacionado> TbProdutoSkuRelacionadoIdProdutoSkuRelacaoNavigation { get; set; }
        public virtual ICollection<TbProdutoSkuVendaCasada> TbProdutoSkuVendaCasadaIdProdutoSkuCasadoNavigation { get; set; }
        public virtual ICollection<TbProdutoSkuVendaCasada> TbProdutoSkuVendaCasadaIdProdutoSkuNavigation { get; set; }
        public virtual ICollection<TbProgramaProduto> TbProgramaProduto { get; set; }
        public virtual ICollection<TbQuemComprouComprouTambem> TbQuemComprouComprouTambem { get; set; }
        public virtual ICollection<TbQuemViuComprou> TbQuemViuComprouIdProdutoSkuCompradoNavigation { get; set; }
        public virtual ICollection<TbQuemViuComprou> TbQuemViuComprouIdProdutoSkuVistoNavigation { get; set; }
        public virtual ICollection<TbQuemViuViuTambem> TbQuemViuViuTambemIdProdutoSkuNavigation { get; set; }
        public virtual ICollection<TbQuemViuViuTambem> TbQuemViuViuTambemIdProdutoSkuVistoNavigation { get; set; }
        public virtual ICollection<TbSuperDesconto> TbSuperDesconto { get; set; }
        public virtual ICollection<TbVitrineProdutoSku> TbVitrineProdutoSku { get; set; }
    }
}
