using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class MensagemCategoria
    {
        public int IdMensagemCategoria { get; set; }
        public int IdMensagem { get; set; }
        public int? IdCategoria { get; set; }
        public int? BackofficeDepartamento { get; set; }
        public int? BackofficeSecao { get; set; }
        public int? BackofficeCategoria { get; set; }
        public int? BackofficeSubcategoria { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Mensagem IdMensagemNavigation { get; set; }
    }
}
