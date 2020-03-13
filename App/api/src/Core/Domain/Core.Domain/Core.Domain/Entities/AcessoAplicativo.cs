using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class AcessoAplicativo
    {
        public int IdAcessoAplicativo { get; set; }
        public int IdAcesso { get; set; }
        public int IdAplicativo { get; set; }

        public virtual Aplicativo IdAplicativoNavigation { get; set; }
    }
}
