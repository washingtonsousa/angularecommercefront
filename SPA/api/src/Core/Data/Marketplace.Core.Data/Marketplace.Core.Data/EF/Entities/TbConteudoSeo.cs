using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbConteudoSeo
    {
        public int IdConteudoSeo { get; set; }
        public int IdConteudo { get; set; }
        public string DsDescription { get; set; }
        public string DsTitle { get; set; }
        public string DsKeywords { get; set; }

        public virtual TbConteudo IdConteudoNavigation { get; set; }
    }
}
