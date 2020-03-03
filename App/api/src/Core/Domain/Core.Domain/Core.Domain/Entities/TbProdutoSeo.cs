using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbProdutoSeo
    {
        public int IdProdutoSeo { get; set; }
        public int IdProduto { get; set; }
        public string DsDescription { get; set; }
        public string DsTitle { get; set; }
        public string DsKeywords { get; set; }

        public virtual TbProduto IdProdutoNavigation { get; set; }
    }
}
