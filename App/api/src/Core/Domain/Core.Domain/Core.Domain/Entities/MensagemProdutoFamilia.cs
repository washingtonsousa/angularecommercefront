using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class MensagemProdutoFamilia
    {
        public int IdMensagemProdutoFamilia { get; set; }
        public int IdMensagem { get; set; }
        public int IdProdutoFamilia { get; set; }

        public virtual Mensagem IdMensagemNavigation { get; set; }
        public virtual ProdutoFamilia IdProdutoFamiliaNavigation { get; set; }
    }
}
