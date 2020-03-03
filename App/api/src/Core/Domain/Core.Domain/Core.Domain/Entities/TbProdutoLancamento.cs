using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbProdutoLancamento
    {
        public int IdProdutoLancamento { get; set; }
        public int IdProduto { get; set; }
        public DateTime DtInicial { get; set; }
        public DateTime DtFinal { get; set; }

        public virtual TbProduto IdProdutoNavigation { get; set; }
    }
}
