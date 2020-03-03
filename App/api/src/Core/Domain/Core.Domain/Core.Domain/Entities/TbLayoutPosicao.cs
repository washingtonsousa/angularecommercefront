using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbLayoutPosicao
    {
        public TbLayoutPosicao()
        {
            TbBanner = new HashSet<TbBanner>();
        }

        public int IdLayoutPosicao { get; set; }
        public int IdLayout { get; set; }
        public int IdPosicao { get; set; }
        public int? NuLargura { get; set; }
        public int? NuAltura { get; set; }

        public virtual TbLayout IdLayoutNavigation { get; set; }
        public virtual TbPosicao IdPosicaoNavigation { get; set; }
        public virtual ICollection<TbBanner> TbBanner { get; set; }
    }
}
