using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbPromocaoProduto
    {
        public int IdPromocaoProduto { get; set; }
        public int IdPromocao { get; set; }
        public int IdProduto { get; set; }

        public virtual TbProduto IdProdutoNavigation { get; set; }
        public virtual TbPromocao IdPromocaoNavigation { get; set; }
    }
}
