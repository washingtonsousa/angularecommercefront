using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class UploadImagem
    {
        public int IdUploadImagem { get; set; }
        public string DsArquivo { get; set; }
        public string DsUrl { get; set; }
    }
}
