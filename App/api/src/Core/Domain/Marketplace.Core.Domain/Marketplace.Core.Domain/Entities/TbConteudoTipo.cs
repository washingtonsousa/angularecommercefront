using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbConteudoTipo
    {
        public TbConteudoTipo()
        {
            TbConteudo = new HashSet<TbConteudo>();
        }

        public int IdConteudoTipo { get; set; }
        public string NmConteudoTipo { get; set; }

        public virtual ICollection<TbConteudo> TbConteudo { get; set; }
    }
}
