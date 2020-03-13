using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class VitrineProdutoSku
    {
        public int IdVitrineProdutoSku { get; set; }
        public int IdVitrine { get; set; }
        public int IdProdutoSku { get; set; }
        public int NuOrdem { get; set; }

        public virtual ProdutoSku IdProdutoSkuNavigation { get; set; }
        public virtual Vitrine IdVitrineNavigation { get; set; }
    }
}
