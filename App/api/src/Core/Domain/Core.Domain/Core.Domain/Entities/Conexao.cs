using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Conexao
    {
        public int IdConexao { get; set; }
        public string NmConexao { get; set; }
        public string DsConexao { get; set; }
    }
}
