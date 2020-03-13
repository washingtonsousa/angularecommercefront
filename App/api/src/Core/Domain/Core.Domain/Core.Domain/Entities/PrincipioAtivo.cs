using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PrincipioAtivo
    {
        public PrincipioAtivo()
        {
            MensagemPrincipioAtivo = new HashSet<MensagemPrincipioAtivo>();
            ProdutoPrincipioAtivo = new HashSet<ProdutoPrincipioAtivo>();
        }

        public int IdPrincipioAtivo { get; set; }
        public string CdExterno { get; set; }
        public string DsPrincipioAtivo { get; set; }
        public int? IdPrincipioAtivoVannon { get; set; }

        public virtual ICollection<MensagemPrincipioAtivo> MensagemPrincipioAtivo { get; set; }
        public virtual ICollection<ProdutoPrincipioAtivo> ProdutoPrincipioAtivo { get; set; }
    }
}
