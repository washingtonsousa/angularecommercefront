using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PagamentoParcela
    {
        public int IdPagamentoParcela { get; set; }
        public int IdPagamento { get; set; }
        public int NuParcela { get; set; }
        public decimal VlParcelaMinima { get; set; }
        public decimal VlJurosMes { get; set; }
        public string NmPagamentoParcela { get; set; }
        public decimal VlDesconto { get; set; }

        public virtual Pagamento IdPagamentoNavigation { get; set; }
    }
}
