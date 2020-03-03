using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbSkuPracaMovimentacao
    {
        public int IdProdutoSkuPraca { get; set; }
        public decimal VlPrecoAtual { get; set; }
        public decimal VlPrecoNovo { get; set; }
        public int NuEstoqueAtual { get; set; }
        public int NuEstoqueEntrada { get; set; }
        public int NuEstoqueReservado { get; set; }
        public int NuEstoqueDisponivel { get; set; }
        public DateTime DtMovimentacao { get; set; }

        public virtual TbProdutoSkuPraca IdProdutoSkuPracaNavigation { get; set; }
    }
}
