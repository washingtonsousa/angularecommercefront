using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbPromocaoTipoAcao
    {
        public int IdPromocaoTipoAcao { get; set; }
        public int IdPromocaoTipo { get; set; }
        public int IdPromocaoAcao { get; set; }

        public virtual TbPromocaoAcao IdPromocaoAcaoNavigation { get; set; }
        public virtual TbPromocaoTipo IdPromocaoTipoNavigation { get; set; }
    }
}
