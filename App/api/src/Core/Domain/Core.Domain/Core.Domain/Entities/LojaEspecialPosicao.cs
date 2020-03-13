using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class LojaEspecialPosicao
    {
        public LojaEspecialPosicao()
        {
            LojaEspecialBanner = new HashSet<LojaEspecialBanner>();
        }

        public int IdLojaEspecialPosicao { get; set; }
        public string NmLojaEspecialPosicao { get; set; }
        public int NuAltura { get; set; }
        public int NuLargura { get; set; }

        public virtual ICollection<LojaEspecialBanner> LojaEspecialBanner { get; set; }
    }
}
