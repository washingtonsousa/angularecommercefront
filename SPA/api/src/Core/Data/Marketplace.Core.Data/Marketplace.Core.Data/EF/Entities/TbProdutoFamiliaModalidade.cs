using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbProdutoFamiliaModalidade
    {
        public int IdProdutoFamiliaModalidade { get; set; }
        public int IdProdutoFamilia { get; set; }
        public int IdModalidadeEntrega { get; set; }
        public string DsMensagem { get; set; }

        public virtual TbModalidadeEntrega IdModalidadeEntregaNavigation { get; set; }
        public virtual TbProdutoFamilia IdProdutoFamiliaNavigation { get; set; }
    }
}
