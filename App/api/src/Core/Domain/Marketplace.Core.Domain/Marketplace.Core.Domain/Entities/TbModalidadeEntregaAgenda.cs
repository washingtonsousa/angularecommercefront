using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbModalidadeEntregaAgenda
    {
        public int IdModalidadeEntregaAgenda { get; set; }
        public int IdModalidadeEntrega { get; set; }
        public int IdDiaSemana { get; set; }
        public DateTime DtHorarioInicio { get; set; }
        public DateTime DtHorarioFinal { get; set; }
        public decimal? VlAdicional { get; set; }

        public virtual TbDiaSemana IdDiaSemanaNavigation { get; set; }
        public virtual TbModalidadeEntrega IdModalidadeEntregaNavigation { get; set; }
    }
}
