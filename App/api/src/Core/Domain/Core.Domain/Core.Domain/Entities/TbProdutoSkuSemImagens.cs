using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbProdutoSkuSemImagens
    {
        public string CdBarras { get; set; }
        public int SkuVfarma { get; set; }
        public bool FlStatus { get; set; }
        public bool FlPrincipal { get; set; }
        public bool? FlSecundaria { get; set; }
        public string DsImagem { get; set; }
        public string Origem { get; set; }
        public bool FlIntegrado { get; set; }
    }
}
