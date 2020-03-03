using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Vannonline
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public string Satisfacao { get; set; }
        public string Assunto { get; set; }
        public string Solicitante { get; set; }
        public DateTime? Data { get; set; }
        public string Organizacao { get; set; }
    }
}
