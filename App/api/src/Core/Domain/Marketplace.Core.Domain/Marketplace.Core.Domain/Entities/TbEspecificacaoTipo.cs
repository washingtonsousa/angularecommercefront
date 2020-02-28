using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbEspecificacaoTipo
    {
        public TbEspecificacaoTipo()
        {
            TbEspecificacao = new HashSet<TbEspecificacao>();
        }

        public int IdEspecificacaoTipo { get; set; }
        public string NmEspecificacaoTipo { get; set; }
        public string CdExterno { get; set; }

        public virtual ICollection<TbEspecificacao> TbEspecificacao { get; set; }
    }
}
