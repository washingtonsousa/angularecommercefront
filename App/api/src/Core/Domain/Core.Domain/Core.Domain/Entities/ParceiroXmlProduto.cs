using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ParceiroXmlProduto
    {
        public int IdParceiroXmlProduto { get; set; }
        public int IdParceiro { get; set; }
        public int IdProdutoSku { get; set; }

        public virtual Parceiro IdParceiroNavigation { get; set; }
        public virtual ProdutoSku IdProdutoSkuNavigation { get; set; }
    }
}
