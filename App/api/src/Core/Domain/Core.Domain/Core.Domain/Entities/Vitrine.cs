using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Vitrine
    {
        public Vitrine()
        {
            BannerVitrine = new HashSet<BannerVitrine>();
            VitrineCategoria = new HashSet<VitrineCategoria>();
            VitrinePraca = new HashSet<VitrinePraca>();
            VitrineProdutoSku = new HashSet<VitrineProdutoSku>();
        }

        public int IdVitrine { get; set; }
        public int IdVitrineTipo { get; set; }
        public bool FlStatus { get; set; }
        public byte NuOrdem { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFinal { get; set; }
        public DateTime DtCadastro { get; set; }
        public string NmVitrine { get; set; }

        public virtual VitrineTipo IdVitrineTipoNavigation { get; set; }
        public virtual ICollection<BannerVitrine> BannerVitrine { get; set; }
        public virtual ICollection<VitrineCategoria> VitrineCategoria { get; set; }
        public virtual ICollection<VitrinePraca> VitrinePraca { get; set; }
        public virtual ICollection<VitrineProdutoSku> VitrineProdutoSku { get; set; }
    }
}
