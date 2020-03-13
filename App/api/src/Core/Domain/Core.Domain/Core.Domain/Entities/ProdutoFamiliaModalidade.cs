using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoFamiliaModalidade
    {
        public int IdProdutoFamiliaModalidade { get; set; }
        public int IdProdutoFamilia { get; set; }
        public int IdModalidadeEntrega { get; set; }
        public string DsMensagem { get; set; }

        public virtual ModalidadeEntrega IdModalidadeEntregaNavigation { get; set; }
        public virtual ProdutoFamilia IdProdutoFamiliaNavigation { get; set; }
    }
}
