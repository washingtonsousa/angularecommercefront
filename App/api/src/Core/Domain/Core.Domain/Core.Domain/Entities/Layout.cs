using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Layout
    {
        public Layout()
        {
            LayoutPosicao = new HashSet<LayoutPosicao>();
        }

        public int IdLayout { get; set; }
        public string NmLayout { get; set; }
        public string DsImagem { get; set; }

        public virtual ICollection<LayoutPosicao> LayoutPosicao { get; set; }
    }
}
