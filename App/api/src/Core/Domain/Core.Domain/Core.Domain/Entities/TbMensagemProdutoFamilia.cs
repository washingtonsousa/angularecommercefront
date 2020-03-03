using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbMensagemProdutoFamilia
    {
        public int IdMensagemProdutoFamilia { get; set; }
        public int IdMensagem { get; set; }
        public int IdProdutoFamilia { get; set; }

        public virtual TbMensagem IdMensagemNavigation { get; set; }
        public virtual TbProdutoFamilia IdProdutoFamiliaNavigation { get; set; }
    }
}
