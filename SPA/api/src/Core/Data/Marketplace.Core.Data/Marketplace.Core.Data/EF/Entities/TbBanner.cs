using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbBanner
    {
        public TbBanner()
        {
            TbBannerBusca = new HashSet<TbBannerBusca>();
            TbBannerCategoria = new HashSet<TbBannerCategoria>();
            TbBannerPraca = new HashSet<TbBannerPraca>();
            TbBannerProduto = new HashSet<TbBannerProduto>();
            TbBannerVitrine = new HashSet<TbBannerVitrine>();
        }

        public int IdBanner { get; set; }
        public int IdBannerTarget { get; set; }
        public int IdLayoutPosicao { get; set; }
        public bool FlPadrao { get; set; }
        public bool FlStatus { get; set; }
        public int? NuOrdem { get; set; }
        public int NuClick { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime DtInicial { get; set; }
        public DateTime DtFinal { get; set; }
        public string NmBanner { get; set; }
        public string DsArquivoBanner { get; set; }
        public string DsImagemIcone { get; set; }
        public string DsLinkBanner { get; set; }
        public int? NuAlturaPopup { get; set; }
        public int? NuLarguraPopup { get; set; }
        public string DsFundoHexadecimal { get; set; }
        public string DsFundoImagem { get; set; }
        public string DsDescricao { get; set; }

        public virtual TbBannerTarget IdBannerTargetNavigation { get; set; }
        public virtual TbLayoutPosicao IdLayoutPosicaoNavigation { get; set; }
        public virtual ICollection<TbBannerBusca> TbBannerBusca { get; set; }
        public virtual ICollection<TbBannerCategoria> TbBannerCategoria { get; set; }
        public virtual ICollection<TbBannerPraca> TbBannerPraca { get; set; }
        public virtual ICollection<TbBannerProduto> TbBannerProduto { get; set; }
        public virtual ICollection<TbBannerVitrine> TbBannerVitrine { get; set; }
    }
}
