using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbLayout
    {
        public TbLayout()
        {
            TbLayoutPosicao = new HashSet<TbLayoutPosicao>();
        }

        public int IdLayout { get; set; }
        public string NmLayout { get; set; }
        public string DsImagem { get; set; }

        public virtual ICollection<TbLayoutPosicao> TbLayoutPosicao { get; set; }
    }
}
