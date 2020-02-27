using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbServicoCorreios
    {
        public TbServicoCorreios()
        {
            TbModalidadeEntrega = new HashSet<TbModalidadeEntrega>();
        }

        public int IdServicoCorreios { get; set; }
        public string CdServicoCorreios { get; set; }
        public string NmServicoCorreios { get; set; }

        public virtual ICollection<TbModalidadeEntrega> TbModalidadeEntrega { get; set; }
    }
}
