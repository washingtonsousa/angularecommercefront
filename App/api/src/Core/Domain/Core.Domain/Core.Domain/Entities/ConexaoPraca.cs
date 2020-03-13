using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ConexaoPraca
    {
        public int IdConexaoPraca { get; set; }
        public int IdConexao { get; set; }
        public int IdPraca { get; set; }
    }
}
