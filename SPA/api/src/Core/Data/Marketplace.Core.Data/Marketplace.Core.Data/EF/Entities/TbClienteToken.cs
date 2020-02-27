﻿using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
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
