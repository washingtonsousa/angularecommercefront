using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Autorizador
    {
        public int IdAutorizador { get; set; }
        public int CdExterno { get; set; }
        public string CdDescricao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public DateTime? DtAlteracao { get; set; }
    }
}
