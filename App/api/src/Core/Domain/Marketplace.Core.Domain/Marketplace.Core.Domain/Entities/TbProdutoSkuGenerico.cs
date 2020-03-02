using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbProdutoSkuGenerico
    {
        public int IdProdutoSkuGenerico { get; set; }
        public int IdMedicamento { get; set; }
        public int IdGenerico { get; set; }

        public virtual ProdutoSku IdGenericoNavigation { get; set; }
        public virtual ProdutoSku IdMedicamentoNavigation { get; set; }
    }
}
