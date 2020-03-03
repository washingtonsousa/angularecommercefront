using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbProdutoPrincipioAtivoBkp20191018
    {
        public int IdProdutoPrincipioAtivo { get; set; }
        public int IdProduto { get; set; }
        public int IdPrincipioAtivo { get; set; }
        public bool? FlPrincipal { get; set; }
    }
}
