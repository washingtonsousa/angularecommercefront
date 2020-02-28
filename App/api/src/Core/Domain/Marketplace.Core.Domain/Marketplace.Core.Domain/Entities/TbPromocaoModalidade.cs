using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbPromocaoModalidade
    {
        public int IdPromocaoModalidade { get; set; }
        public int IdPromocao { get; set; }
        public int IdModalidadeEntrega { get; set; }

        public virtual TbModalidadeEntrega IdModalidadeEntregaNavigation { get; set; }
        public virtual TbPromocao IdPromocaoNavigation { get; set; }
    }
}
