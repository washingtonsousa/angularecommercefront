using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbClienteToken
    {
        public int IdClienteToken { get; set; }
        public int? IdCliente { get; set; }
        public bool? FlSenha { get; set; }
        public string DsToken { get; set; }
        public DateTime? DtInclusao { get; set; }
        public bool? FlExpirado { get; set; }
    }
}
