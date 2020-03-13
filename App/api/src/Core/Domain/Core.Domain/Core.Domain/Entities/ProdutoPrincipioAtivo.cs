using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoPrincipioAtivo
    {
        public int IdProdutoPrincipioAtivo { get; set; }
        public int IdProduto { get; set; }
        public int IdPrincipioAtivo { get; set; }
        public bool? FlPrincipal { get; set; }

        public virtual PrincipioAtivo IdPrincipioAtivoNavigation { get; set; }
        public virtual Produto IdProdutoNavigation { get; set; }
    }
}
