using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ConteudoConteudoLocal
    {
        public int IdConteudoConteudoLocal { get; set; }
        public int IdConteudo { get; set; }
        public int IdConteudoLocal { get; set; }

        public virtual ConteudoLocal IdConteudoLocalNavigation { get; set; }
        public virtual Conteudo IdConteudoNavigation { get; set; }
    }
}
