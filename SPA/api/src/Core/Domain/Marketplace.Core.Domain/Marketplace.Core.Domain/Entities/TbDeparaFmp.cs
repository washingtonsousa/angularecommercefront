using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbDeparaFmp
    {
        public int IdDepara { get; set; }
        public int IdConexao { get; set; }
        public string NmTabela { get; set; }
        public int IdDe { get; set; }
        public int IdPara { get; set; }
    }
}
