using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Busca
    {
        public int IdBusca { get; set; }
        public int NuQtdBusca { get; set; }
        public DateTime DtUltimaBusca { get; set; }
        public string DsTermoBusca { get; set; }
    }
}
