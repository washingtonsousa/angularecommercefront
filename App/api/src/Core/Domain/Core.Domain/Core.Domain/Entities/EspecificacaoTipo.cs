using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class EspecificacaoTipo
    {
        public EspecificacaoTipo()
        {
            Especificacao = new HashSet<Especificacao>();
        }

        public int IdEspecificacaoTipo { get; set; }
        public string NmEspecificacaoTipo { get; set; }
        public string CdExterno { get; set; }

        public virtual ICollection<Especificacao> Especificacao { get; set; }
    }
}
