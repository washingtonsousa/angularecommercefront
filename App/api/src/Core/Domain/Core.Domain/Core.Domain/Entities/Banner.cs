using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Banner
    {
        public Banner()
        {
            BannerBusca = new HashSet<BannerBusca>();
            BannerCategoria = new HashSet<BannerCategoria>();
            BannerPraca = new HashSet<BannerPraca>();
            BannerProduto = new HashSet<BannerProduto>();
            BannerVitrine = new HashSet<BannerVitrine>();
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

        public virtual BannerTarget IdBannerTargetNavigation { get; set; }
        public virtual LayoutPosicao IdLayoutPosicaoNavigation { get; set; }
        public virtual ICollection<BannerBusca> BannerBusca { get; set; }
        public virtual ICollection<BannerCategoria> BannerCategoria { get; set; }
        public virtual ICollection<BannerPraca> BannerPraca { get; set; }
        public virtual ICollection<BannerProduto> BannerProduto { get; set; }
        public virtual ICollection<BannerVitrine> BannerVitrine { get; set; }
    }
}
