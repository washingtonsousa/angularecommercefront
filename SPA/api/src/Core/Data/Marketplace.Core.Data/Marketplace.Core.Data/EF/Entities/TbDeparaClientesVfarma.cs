using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbDeparaClientesVfarma
    {
        public int IdDeparaClientesVfarma { get; set; }
        public int IdConexao { get; set; }
        public string NmTabela { get; set; }
        public int? IdDe { get; set; }
        public string DsDe { get; set; }
        public int? IdPara { get; set; }
    }
}
