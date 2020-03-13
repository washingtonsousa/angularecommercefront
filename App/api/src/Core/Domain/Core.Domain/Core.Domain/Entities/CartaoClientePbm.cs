using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class CartaoClientePbm
    {
        public int IdCartaoClientePbm { get; set; }
        public int IdServico { get; set; }
        public long CpfCliente { get; set; }
        public long NmCartao { get; set; }
        public string DsPrograma { get; set; }
        public DateTime? DtInclusao { get; set; }
    }
}
