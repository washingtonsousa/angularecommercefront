using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbLojaEspecialVitrine
    {
        public TbLojaEspecialVitrine()
        {
            TbLojaEspecialVitrineProduto = new HashSet<TbLojaEspecialVitrineProduto>();
        }

        public int IdLojaEspecialVitrine { get; set; }
        public int IdLojaEspecial { get; set; }
        public bool FlStatus { get; set; }
        public byte NuOrdem { get; set; }
        public string NmVitrine { get; set; }

        public virtual TbLojaEspecial IdLojaEspecialNavigation { get; set; }
        public virtual ICollection<TbLojaEspecialVitrineProduto> TbLojaEspecialVitrineProduto { get; set; }
    }
}
