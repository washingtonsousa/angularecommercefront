using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class UsuarioRecuperacao
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public DateTime Data { get; set; }
        public string Cookie { get; set; }
    }
}
