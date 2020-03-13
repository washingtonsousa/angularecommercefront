using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ConteudoCategoria
    {
        public ConteudoCategoria()
        {
            Conteudo = new HashSet<Conteudo>();
        }

        public int IdConteudoCategoria { get; set; }
        public bool FlStatus { get; set; }
        public byte NuOrdem { get; set; }
        public string NmConteudoCategoria { get; set; }

        public virtual ICollection<Conteudo> Conteudo { get; set; }
    }
}
