using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbProdutoVideo
    {
        public int IdProdutoVideo { get; set; }
        public int IdProduto { get; set; }
        public bool FlStatus { get; set; }
        public string NmVideo { get; set; }
        public string DsUrl { get; set; }
        public string TxVideo { get; set; }

        public virtual TbProduto IdProdutoNavigation { get; set; }
    }
}
