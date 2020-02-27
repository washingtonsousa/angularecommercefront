using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbMensagemMarca
    {
        public int IdMensagemMarca { get; set; }
        public int IdMensagem { get; set; }
        public int IdMarca { get; set; }

        public virtual TbMarca IdMarcaNavigation { get; set; }
        public virtual TbMensagem IdMensagemNavigation { get; set; }
    }
}
