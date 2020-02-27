using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbVitrineProdutoSku
    {
        public int IdVitrineProdutoSku { get; set; }
        public int IdVitrine { get; set; }
        public int IdProdutoSku { get; set; }
        public int NuOrdem { get; set; }

        public virtual TbProdutoSku IdProdutoSkuNavigation { get; set; }
        public virtual TbVitrine IdVitrineNavigation { get; set; }
    }
}
