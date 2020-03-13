using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class LayoutPosicao
    {
        public LayoutPosicao()
        {
            Banner = new HashSet<Banner>();
        }

        public int IdLayoutPosicao { get; set; }
        public int IdLayout { get; set; }
        public int IdPosicao { get; set; }
        public int? NuLargura { get; set; }
        public int? NuAltura { get; set; }

        public virtual Layout IdLayoutNavigation { get; set; }
        public virtual Posicao IdPosicaoNavigation { get; set; }
        public virtual ICollection<Banner> Banner { get; set; }
    }
}
