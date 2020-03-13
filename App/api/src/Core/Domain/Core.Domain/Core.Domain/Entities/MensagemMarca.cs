using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class MensagemMarca
    {
        public int IdMensagemMarca { get; set; }
        public int IdMensagem { get; set; }
        public int IdMarca { get; set; }

        public virtual Marca IdMarcaNavigation { get; set; }
        public virtual Mensagem IdMensagemNavigation { get; set; }
    }
}
