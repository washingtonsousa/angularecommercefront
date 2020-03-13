using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class DiaSemana
    {
        public DiaSemana()
        {
            ModalidadeEntregaAgenda = new HashSet<ModalidadeEntregaAgenda>();
        }

        public int IdDiaSemana { get; set; }
        public string DsDiaSemana { get; set; }

        public virtual ICollection<ModalidadeEntregaAgenda> ModalidadeEntregaAgenda { get; set; }
    }
}
