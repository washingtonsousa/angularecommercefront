using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbVitrine
    {
        public TbVitrine()
        {
            TbBannerVitrine = new HashSet<TbBannerVitrine>();
            TbVitrineCategoria = new HashSet<TbVitrineCategoria>();
            TbVitrinePraca = new HashSet<TbVitrinePraca>();
            TbVitrineProdutoSku = new HashSet<TbVitrineProdutoSku>();
        }

        public int IdVitrine { get; set; }
        public int IdVitrineTipo { get; set; }
        public bool FlStatus { get; set; }
        public byte NuOrdem { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFinal { get; set; }
        public DateTime DtCadastro { get; set; }
        public string NmVitrine { get; set; }

        public virtual TbVitrineTipo IdVitrineTipoNavigation { get; set; }
        public virtual ICollection<TbBannerVitrine> TbBannerVitrine { get; set; }
        public virtual ICollection<TbVitrineCategoria> TbVitrineCategoria { get; set; }
        public virtual ICollection<TbVitrinePraca> TbVitrinePraca { get; set; }
        public virtual ICollection<TbVitrineProdutoSku> TbVitrineProdutoSku { get; set; }
    }
}
