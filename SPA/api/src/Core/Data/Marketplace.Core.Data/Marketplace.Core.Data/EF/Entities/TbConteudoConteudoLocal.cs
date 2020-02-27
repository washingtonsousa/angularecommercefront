using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbConteudoConteudoLocal
    {
        public int IdConteudoConteudoLocal { get; set; }
        public int IdConteudo { get; set; }
        public int IdConteudoLocal { get; set; }

        public virtual TbConteudoLocal IdConteudoLocalNavigation { get; set; }
        public virtual TbConteudo IdConteudoNavigation { get; set; }
    }
}
