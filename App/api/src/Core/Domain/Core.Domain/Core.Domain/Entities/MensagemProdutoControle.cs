using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class MensagemProdutoControle
    {
        public int IdMensagemProdutoControle { get; set; }
        public int IdMensagem { get; set; }
        public int IdProdutoControle { get; set; }

        public virtual Mensagem IdMensagemNavigation { get; set; }
        public virtual ProdutoControle IdProdutoControleNavigation { get; set; }
    }
}
