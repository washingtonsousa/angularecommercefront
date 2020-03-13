using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PromocaoModalidade
    {
        public int IdPromocaoModalidade { get; set; }
        public int IdPromocao { get; set; }
        public int IdModalidadeEntrega { get; set; }

        public virtual ModalidadeEntrega IdModalidadeEntregaNavigation { get; set; }
        public virtual Promocao IdPromocaoNavigation { get; set; }
    }
}
