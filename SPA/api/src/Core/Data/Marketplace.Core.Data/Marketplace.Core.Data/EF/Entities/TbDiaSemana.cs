using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbDiaSemana
    {
        public TbDiaSemana()
        {
            TbModalidadeEntregaAgenda = new HashSet<TbModalidadeEntregaAgenda>();
        }

        public int IdDiaSemana { get; set; }
        public string DsDiaSemana { get; set; }

        public virtual ICollection<TbModalidadeEntregaAgenda> TbModalidadeEntregaAgenda { get; set; }
    }
}
