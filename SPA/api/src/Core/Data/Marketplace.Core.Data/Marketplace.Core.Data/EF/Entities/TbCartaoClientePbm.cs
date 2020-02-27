using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbCartaoClientePbm
    {
        public int IdCartaoClientePbm { get; set; }
        public int IdServico { get; set; }
        public long CpfCliente { get; set; }
        public long NmCartao { get; set; }
        public string DsPrograma { get; set; }
        public DateTime? DtInclusao { get; set; }
    }
}
