using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbImpAtualizaTitleMeta
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
