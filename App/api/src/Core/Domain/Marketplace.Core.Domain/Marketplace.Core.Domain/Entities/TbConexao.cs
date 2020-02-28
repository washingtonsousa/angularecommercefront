using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbConexao
    {
        public int IdConexao { get; set; }
        public string NmConexao { get; set; }
        public string DsConexao { get; set; }
    }
}
