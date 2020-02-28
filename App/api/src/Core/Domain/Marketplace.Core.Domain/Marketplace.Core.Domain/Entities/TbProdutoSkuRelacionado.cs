using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbProdutoSkuRelacionado
    {
        public int IdProdutoSkuRelacionado { get; set; }
        public int IdProdutoSku { get; set; }
        public int IdProdutoSkuRelacao { get; set; }

        public virtual TbProdutoSku IdProdutoSkuNavigation { get; set; }
        public virtual TbProdutoSku IdProdutoSkuRelacaoNavigation { get; set; }
    }
}
