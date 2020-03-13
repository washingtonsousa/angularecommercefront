using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ImpAtualizaTitleMeta
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string DsTitle { get; set; }
        public string DsDescription { get; set; }
        public string DsKeywords { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public string DsMensagem { get; set; }
    }
}
