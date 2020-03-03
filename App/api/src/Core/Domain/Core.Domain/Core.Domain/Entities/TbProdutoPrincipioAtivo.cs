using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbProdutoPrincipioAtivo
    {
        public int IdProdutoPrincipioAtivo { get; set; }
        public int IdProduto { get; set; }
        public int IdPrincipioAtivo { get; set; }
        public bool? FlPrincipal { get; set; }

        public virtual TbPrincipioAtivo IdPrincipioAtivoNavigation { get; set; }
        public virtual TbProduto IdProdutoNavigation { get; set; }
    }
}
