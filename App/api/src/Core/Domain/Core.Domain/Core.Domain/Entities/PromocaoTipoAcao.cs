using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PromocaoTipoAcao
    {
        public int IdPromocaoTipoAcao { get; set; }
        public int IdPromocaoTipo { get; set; }
        public int IdPromocaoAcao { get; set; }

        public virtual PromocaoAcao IdPromocaoAcaoNavigation { get; set; }
        public virtual PromocaoTipo IdPromocaoTipoNavigation { get; set; }
    }
}
