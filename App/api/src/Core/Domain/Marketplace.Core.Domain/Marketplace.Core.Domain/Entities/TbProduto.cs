using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbProduto
    {
        public TbProduto()
        {
            TbBannerProduto = new HashSet<TbBannerProduto>();
            TbLojaEspecialProduto = new HashSet<TbLojaEspecialProduto>();
            TbLojaEspecialVitrineProduto = new HashSet<TbLojaEspecialVitrineProduto>();
            TbOfertaEspecial = new HashSet<TbOfertaEspecial>();
            TbProdutoAvaliacao = new HashSet<TbProdutoAvaliacao>();
            TbProdutoCategoria = new HashSet<TbProdutoCategoria>();
            TbProdutoDescricao = new HashSet<TbProdutoDescricao>();
            TbProdutoEtiqueta = new HashSet<TbProdutoEtiqueta>();
            TbProdutoKit = new HashSet<TbProdutoKit>();
            TbProdutoLancamento = new HashSet<TbProdutoLancamento>();
            TbProdutoLog = new HashSet<TbProdutoLog>();
            TbProdutoPrincipioAtivo = new HashSet<TbProdutoPrincipioAtivo>();
            TbProdutoSeo = new HashSet<TbProdutoSeo>();
            TbProdutoSku = new HashSet<ProdutoSku>();
            TbProdutoVideo = new HashSet<TbProdutoVideo>();
            TbPromocaoProduto = new HashSet<TbPromocaoProduto>();
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

        public virtual TbMarca IdMarcaNavigation { get; set; }
        public virtual TbProdutoControle IdProdutoControleNavigation { get; set; }
        public virtual TbProdutoFamilia IdProdutoFamiliaNavigation { get; set; }
        public virtual TbProdutoTipo IdProdutoTipoNavigation { get; set; }
        public virtual ICollection<TbBannerProduto> TbBannerProduto { get; set; }
        public virtual ICollection<TbLojaEspecialProduto> TbLojaEspecialProduto { get; set; }
        public virtual ICollection<TbLojaEspecialVitrineProduto> TbLojaEspecialVitrineProduto { get; set; }
        public virtual ICollection<TbOfertaEspecial> TbOfertaEspecial { get; set; }
        public virtual ICollection<TbProdutoAvaliacao> TbProdutoAvaliacao { get; set; }
        public virtual ICollection<TbProdutoCategoria> TbProdutoCategoria { get; set; }
        public virtual ICollection<TbProdutoDescricao> TbProdutoDescricao { get; set; }
        public virtual ICollection<TbProdutoEtiqueta> TbProdutoEtiqueta { get; set; }
        public virtual ICollection<TbProdutoKit> TbProdutoKit { get; set; }
        public virtual ICollection<TbProdutoLancamento> TbProdutoLancamento { get; set; }
        public virtual ICollection<TbProdutoLog> TbProdutoLog { get; set; }
        public virtual ICollection<TbProdutoPrincipioAtivo> TbProdutoPrincipioAtivo { get; set; }
        public virtual ICollection<TbProdutoSeo> TbProdutoSeo { get; set; }
        public virtual ICollection<ProdutoSku> TbProdutoSku { get; set; }
        public virtual ICollection<TbProdutoVideo> TbProdutoVideo { get; set; }
        public virtual ICollection<TbPromocaoProduto> TbPromocaoProduto { get; set; }
    }
}
