using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ModalidadeEntregaAgenda
    {
        public int IdModalidadeEntregaAgenda { get; set; }
        public int IdModalidadeEntrega { get; set; }
        public int IdDiaSemana { get; set; }
        public DateTime DtHorarioInicio { get; set; }
        public DateTime DtHorarioFinal { get; set; }
        public decimal? VlAdicional { get; set; }

        public virtual DiaSemana IdDiaSemanaNavigation { get; set; }
        public virtual ModalidadeEntrega IdModalidadeEntregaNavigation { get; set; }
    }
}
