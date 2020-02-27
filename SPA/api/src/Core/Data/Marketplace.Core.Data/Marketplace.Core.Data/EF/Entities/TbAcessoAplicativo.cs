using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbAcessoAplicativo
    {
        public int IdAcessoAplicativo { get; set; }
        public int IdAcesso { get; set; }
        public int IdAplicativo { get; set; }

        public virtual TbAplicativo IdAplicativoNavigation { get; set; }
    }
}
