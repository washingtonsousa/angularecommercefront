using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ConteudoTarget
    {
        public ConteudoTarget()
        {
            Conteudo = new HashSet<Conteudo>();
        }

        public int IdConteudoTarget { get; set; }
        public string NmConteudoTarget { get; set; }

        public virtual ICollection<Conteudo> Conteudo { get; set; }
    }
}
