using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PromocaoProduto
    {
        public int IdPromocaoProduto { get; set; }
        public int IdPromocao { get; set; }
        public int IdProduto { get; set; }

        public virtual Produto IdProdutoNavigation { get; set; }
        public virtual Promocao IdPromocaoNavigation { get; set; }
    }
}
