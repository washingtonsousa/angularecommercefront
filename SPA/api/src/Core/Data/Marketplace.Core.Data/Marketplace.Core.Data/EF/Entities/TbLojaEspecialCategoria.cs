using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbLojaEspecialCategoria
    {
        public TbLojaEspecialCategoria()
        {
            TbLojaEspecialProduto = new HashSet<TbLojaEspecialProduto>();
        }

        public int IdLojaEspecialCategoria { get; set; }
        public int IdLojaEspecialSecao { get; set; }
        public bool FlStatus { get; set; }
        public byte NuOrdem { get; set; }
        public string NmCategoria { get; set; }

        public virtual TbLojaEspecialSecao IdLojaEspecialSecaoNavigation { get; set; }
        public virtual ICollection<TbLojaEspecialProduto> TbLojaEspecialProduto { get; set; }
    }
}
