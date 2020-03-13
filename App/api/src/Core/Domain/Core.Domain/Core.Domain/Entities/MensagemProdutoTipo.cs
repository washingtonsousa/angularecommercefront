using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class MensagemProdutoTipo
    {
        public int IdMensagemProdutoTipo { get; set; }
        public int IdMensagem { get; set; }
        public int IdProdutoTipo { get; set; }

        public virtual Mensagem IdMensagemNavigation { get; set; }
        public virtual ProdutoTipo IdProdutoTipoNavigation { get; set; }
    }
}
