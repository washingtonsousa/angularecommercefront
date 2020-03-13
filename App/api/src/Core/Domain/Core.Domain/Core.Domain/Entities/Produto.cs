using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Produto
    {
        public Produto()
        {
            BannerProduto = new HashSet<BannerProduto>();
            LojaEspecialProduto = new HashSet<LojaEspecialProduto>();
            LojaEspecialVitrineProduto = new HashSet<LojaEspecialVitrineProduto>();
            OfertaEspecial = new HashSet<OfertaEspecial>();
            ProdutoAvaliacao = new HashSet<ProdutoAvaliacao>();
            ProdutoCategoria = new HashSet<ProdutoCategoria>();
            ProdutoDescricao = new HashSet<ProdutoDescricao>();
            ProdutoEtiqueta = new HashSet<ProdutoEtiqueta>();
            ProdutoKit = new HashSet<ProdutoKit>();
            ProdutoLancamento = new HashSet<ProdutoLancamento>();
            ProdutoLog = new HashSet<ProdutoLog>();
            ProdutoPrincipioAtivo = new HashSet<ProdutoPrincipioAtivo>();
            ProdutoSeo = new HashSet<ProdutoSeo>();
            ProdutoSku = new HashSet<ProdutoSku>();
            ProdutoVideo = new HashSet<ProdutoVideo>();
            PromocaoProduto = new HashSet<PromocaoProduto>();
        }

        public int IdProduto { get; set; }
        public int IdMarca { get; set; }
        public int? IdProdutoTipo { get; set; }
        public int? IdProdutoControle { get; set; }
        public int? IdProdutoFamilia { get; set; }
        public bool FlStatus { get; set; }
        public bool FlPreVenda { get; set; }
        public bool FlLancamento { get; set; }
        public string CdExterno { get; set; }
        public int NuClick { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime? DtPreVenda { get; set; }
        public DateTime? DtLancamentoInicial { get; set; }
        public DateTime? DtLancamentoFinal { get; set; }
        public string NmProduto { get; set; }
        public string DsPalavraChave { get; set; }
        public string DsDescricaoCurta { get; set; }
        public string DsArquivoBula { get; set; }
        public string DsCurvaAbc { get; set; }
        public int FlPerfil { get; set; }
        public string DsUrlVideo { get; set; }
        public string IdProdutoSap { get; set; }
        public int? IdProdutoVannon { get; set; }

        public virtual Marca IdMarcaNavigation { get; set; }
        public virtual ProdutoControle IdProdutoControleNavigation { get; set; }
        public virtual ProdutoFamilia IdProdutoFamiliaNavigation { get; set; }
        public virtual ProdutoTipo IdProdutoTipoNavigation { get; set; }
        public virtual ICollection<BannerProduto> BannerProduto { get; set; }
        public virtual ICollection<LojaEspecialProduto> LojaEspecialProduto { get; set; }
        public virtual ICollection<LojaEspecialVitrineProduto> LojaEspecialVitrineProduto { get; set; }
        public virtual ICollection<OfertaEspecial> OfertaEspecial { get; set; }
        public virtual ICollection<ProdutoAvaliacao> ProdutoAvaliacao { get; set; }
        public virtual ICollection<ProdutoCategoria> ProdutoCategoria { get; set; }
        public virtual ICollection<ProdutoDescricao> ProdutoDescricao { get; set; }
        public virtual ICollection<ProdutoEtiqueta> ProdutoEtiqueta { get; set; }
        public virtual ICollection<ProdutoKit> ProdutoKit { get; set; }
        public virtual ICollection<ProdutoLancamento> ProdutoLancamento { get; set; }
        public virtual ICollection<ProdutoLog> ProdutoLog { get; set; }
        public virtual ICollection<ProdutoPrincipioAtivo> ProdutoPrincipioAtivo { get; set; }
        public virtual ICollection<ProdutoSeo> ProdutoSeo { get; set; }
        public virtual ICollection<ProdutoSku> ProdutoSku { get; set; }
        public virtual ICollection<ProdutoVideo> ProdutoVideo { get; set; }
        public virtual ICollection<PromocaoProduto> PromocaoProduto { get; set; }
    }
}
