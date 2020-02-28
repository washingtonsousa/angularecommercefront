using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbConteudoTarget
    {
        public TbConteudoTarget()
        {
            TbConteudo = new HashSet<TbConteudo>();
        }

        public int IdConteudoTarget { get; set; }
        public string NmConteudoTarget { get; set; }

        public virtual ICollection<TbConteudo> TbConteudo { get; set; }
    }
}
