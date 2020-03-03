using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbLojaEspecialPosicao
    {
        public TbLojaEspecialPosicao()
        {
            TbLojaEspecialBanner = new HashSet<TbLojaEspecialBanner>();
        }

        public int IdLojaEspecialPosicao { get; set; }
        public string NmLojaEspecialPosicao { get; set; }
        public int NuAltura { get; set; }
        public int NuLargura { get; set; }

        public virtual ICollection<TbLojaEspecialBanner> TbLojaEspecialBanner { get; set; }
    }
}
