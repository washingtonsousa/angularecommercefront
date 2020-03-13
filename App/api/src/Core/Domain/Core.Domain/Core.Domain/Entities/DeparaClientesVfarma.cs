using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class DeparaClientesVfarma
    {
        public int IdDeparaClientesVfarma { get; set; }
        public int IdConexao { get; set; }
        public string NmTabela { get; set; }
        public int? IdDe { get; set; }
        public string DsDe { get; set; }
        public int? IdPara { get; set; }
    }
}
