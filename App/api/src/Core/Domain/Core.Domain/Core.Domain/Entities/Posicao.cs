using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Posicao
    {
        public Posicao()
        {
            LayoutPosicao = new HashSet<LayoutPosicao>();
        }

        public int IdPosicao { get; set; }
        public string NmPosicao { get; set; }

        public virtual ICollection<LayoutPosicao> LayoutPosicao { get; set; }
    }
}
