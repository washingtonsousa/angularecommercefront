using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ServicoCorreios
    {
        public ServicoCorreios()
        {
            ModalidadeEntrega = new HashSet<ModalidadeEntrega>();
        }

        public int IdServicoCorreios { get; set; }
        public string CdServicoCorreios { get; set; }
        public string NmServicoCorreios { get; set; }

        public virtual ICollection<ModalidadeEntrega> ModalidadeEntrega { get; set; }
    }
}
