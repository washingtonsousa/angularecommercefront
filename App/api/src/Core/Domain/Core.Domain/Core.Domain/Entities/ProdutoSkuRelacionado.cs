using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoSkuRelacionado
    {
        public int IdProdutoSkuRelacionado { get; set; }
        public int IdProdutoSku { get; set; }
        public int IdProdutoSkuRelacao { get; set; }

        public virtual ProdutoSku IdProdutoSkuNavigation { get; set; }
        public virtual ProdutoSku IdProdutoSkuRelacaoNavigation { get; set; }
    }
}
