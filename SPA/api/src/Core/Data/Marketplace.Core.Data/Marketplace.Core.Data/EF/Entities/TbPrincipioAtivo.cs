using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbPrincipioAtivo
    {
        public TbPrincipioAtivo()
        {
            TbMensagemPrincipioAtivo = new HashSet<TbMensagemPrincipioAtivo>();
            TbProdutoPrincipioAtivo = new HashSet<TbProdutoPrincipioAtivo>();
        }

        public int IdPrincipioAtivo { get; set; }
        public string CdExterno { get; set; }
        public string DsPrincipioAtivo { get; set; }
        public int? IdPrincipioAtivoVannon { get; set; }

        public virtual ICollection<TbMensagemPrincipioAtivo> TbMensagemPrincipioAtivo { get; set; }
        public virtual ICollection<TbProdutoPrincipioAtivo> TbProdutoPrincipioAtivo { get; set; }
    }
}
