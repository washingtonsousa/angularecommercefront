using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbPosicao
    {
        public TbPosicao()
        {
            TbLayoutPosicao = new HashSet<TbLayoutPosicao>();
        }

        public int IdPosicao { get; set; }
        public string NmPosicao { get; set; }

        public virtual ICollection<TbLayoutPosicao> TbLayoutPosicao { get; set; }
    }
}
