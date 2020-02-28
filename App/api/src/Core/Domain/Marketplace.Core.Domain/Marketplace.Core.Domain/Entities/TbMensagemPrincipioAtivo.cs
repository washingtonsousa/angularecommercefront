using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbMensagemPrincipioAtivo
    {
        public int IdMensagemPrincipioAtivo { get; set; }
        public int IdMensagem { get; set; }
        public int IdPrincipioAtivo { get; set; }

        public virtual TbMensagem IdMensagemNavigation { get; set; }
        public virtual TbPrincipioAtivo IdPrincipioAtivoNavigation { get; set; }
    }
}
