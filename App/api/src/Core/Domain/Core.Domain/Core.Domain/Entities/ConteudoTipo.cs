using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ConteudoTipo
    {
        public ConteudoTipo()
        {
            Conteudo = new HashSet<Conteudo>();
        }

        public int IdConteudoTipo { get; set; }
        public string NmConteudoTipo { get; set; }

        public virtual ICollection<Conteudo> Conteudo { get; set; }
    }
}
