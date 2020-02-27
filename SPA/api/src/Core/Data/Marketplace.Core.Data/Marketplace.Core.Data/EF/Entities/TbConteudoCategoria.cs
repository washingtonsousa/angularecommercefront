using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbConteudoCategoria
    {
        public TbConteudoCategoria()
        {
            TbConteudo = new HashSet<TbConteudo>();
        }

        public int IdConteudoCategoria { get; set; }
        public bool FlStatus { get; set; }
        public byte NuOrdem { get; set; }
        public string NmConteudoCategoria { get; set; }

        public virtual ICollection<TbConteudo> TbConteudo { get; set; }
    }
}
