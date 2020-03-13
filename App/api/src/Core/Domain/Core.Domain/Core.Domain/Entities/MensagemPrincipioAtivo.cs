using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class MensagemPrincipioAtivo
    {
        public int IdMensagemPrincipioAtivo { get; set; }
        public int IdMensagem { get; set; }
        public int IdPrincipioAtivo { get; set; }

        public virtual Mensagem IdMensagemNavigation { get; set; }
        public virtual PrincipioAtivo IdPrincipioAtivoNavigation { get; set; }
    }
}
