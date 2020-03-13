using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoSku
    {
        public ProdutoSku()
        {
            Categoria = new HashSet<Categoria>();
            GondolaProdutoSku = new HashSet<GondolaProdutoSku>();
            ListaDesejoProdutoSku = new HashSet<ListaDesejoProdutoSku>();
            ParceiroXmlProduto = new HashSet<ParceiroXmlProduto>();
            PedidoProdutoKit = new HashSet<PedidoProdutoKit>();
            PedidoProdutoSku = new HashSet<PedidoProdutoSku>();
            ProdutoKit = new HashSet<ProdutoKit>();
            ProdutoSkuAviseMe = new HashSet<ProdutoSkuAviseMe>();
            ProdutoSkuEspecificacao = new HashSet<ProdutoSkuEspecificacao>();
            ProdutoSkuFiltro = new HashSet<ProdutoSkuFiltro>();
            ProdutoSkuGenericoIdGenericoNavigation = new HashSet<ProdutoSkuGenerico>();
            ProdutoSkuGenericoIdMedicamentoNavigation = new HashSet<ProdutoSkuGenerico>();
            ProdutoSkuImagem = new HashSet<ProdutoSkuImagem>();
            ProdutoSkuPraca = new HashSet<ProdutoSkuPraca>();
            ProdutoSkuRelacionadoIdProdutoSkuNavigation = new HashSet<ProdutoSkuRelacionado>();
            ProdutoSkuRelacionadoIdProdutoSkuRelacaoNavigation = new HashSet<ProdutoSkuRelacionado>();
            ProdutoSkuVendaCasadaIdProdutoSkuCasadoNavigation = new HashSet<ProdutoSkuVendaCasada>();
            ProdutoSkuVendaCasadaIdProdutoSkuNavigation = new HashSet<ProdutoSkuVendaCasada>();
            ProgramaProduto = new HashSet<ProgramaProduto>();
            QuemComprouComprouTambem = new HashSet<QuemComprouComprouTambem>();
            QuemViuComprouIdProdutoSkuCompradoNavigation = new HashSet<QuemViuComprou>();
            QuemViuComprouIdProdutoSkuVistoNavigation = new HashSet<QuemViuComprou>();
            QuemViuViuTambemIdProdutoSkuNavigation = new HashSet<QuemViuViuTambem>();
            QuemViuViuTambemIdProdutoSkuVistoNavigation = new HashSet<QuemViuViuTambem>();
            SuperDesconto = new HashSet<SuperDesconto>();
            VitrineProdutoSku = new HashSet<VitrineProdutoSku>();
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

        public virtual Produto IdProdutoNavigation { get; set; }
        public virtual ICollection<Categoria> Categoria { get; set; }
        public virtual ICollection<GondolaProdutoSku> GondolaProdutoSku { get; set; }
        public virtual ICollection<ListaDesejoProdutoSku> ListaDesejoProdutoSku { get; set; }
        public virtual ICollection<ParceiroXmlProduto> ParceiroXmlProduto { get; set; }
        public virtual ICollection<PedidoProdutoKit> PedidoProdutoKit { get; set; }
        public virtual ICollection<PedidoProdutoSku> PedidoProdutoSku { get; set; }
        public virtual ICollection<ProdutoKit> ProdutoKit { get; set; }
        public virtual ICollection<ProdutoSkuAviseMe> ProdutoSkuAviseMe { get; set; }
        public virtual ICollection<ProdutoSkuEspecificacao> ProdutoSkuEspecificacao { get; set; }
        public virtual ICollection<ProdutoSkuFiltro> ProdutoSkuFiltro { get; set; }
        public virtual ICollection<ProdutoSkuGenerico> ProdutoSkuGenericoIdGenericoNavigation { get; set; }
        public virtual ICollection<ProdutoSkuGenerico> ProdutoSkuGenericoIdMedicamentoNavigation { get; set; }
        public virtual ICollection<ProdutoSkuImagem> ProdutoSkuImagem { get; set; }
        public virtual ICollection<ProdutoSkuPraca> ProdutoSkuPraca { get; set; }
        public virtual ICollection<ProdutoSkuRelacionado> ProdutoSkuRelacionadoIdProdutoSkuNavigation { get; set; }
        public virtual ICollection<ProdutoSkuRelacionado> ProdutoSkuRelacionadoIdProdutoSkuRelacaoNavigation { get; set; }
        public virtual ICollection<ProdutoSkuVendaCasada> ProdutoSkuVendaCasadaIdProdutoSkuCasadoNavigation { get; set; }
        public virtual ICollection<ProdutoSkuVendaCasada> ProdutoSkuVendaCasadaIdProdutoSkuNavigation { get; set; }
        public virtual ICollection<ProgramaProduto> ProgramaProduto { get; set; }
        public virtual ICollection<QuemComprouComprouTambem> QuemComprouComprouTambem { get; set; }
        public virtual ICollection<QuemViuComprou> QuemViuComprouIdProdutoSkuCompradoNavigation { get; set; }
        public virtual ICollection<QuemViuComprou> QuemViuComprouIdProdutoSkuVistoNavigation { get; set; }
        public virtual ICollection<QuemViuViuTambem> QuemViuViuTambemIdProdutoSkuNavigation { get; set; }
        public virtual ICollection<QuemViuViuTambem> QuemViuViuTambemIdProdutoSkuVistoNavigation { get; set; }
        public virtual ICollection<SuperDesconto> SuperDesconto { get; set; }
        public virtual ICollection<VitrineProdutoSku> VitrineProdutoSku { get; set; }
    }
}
