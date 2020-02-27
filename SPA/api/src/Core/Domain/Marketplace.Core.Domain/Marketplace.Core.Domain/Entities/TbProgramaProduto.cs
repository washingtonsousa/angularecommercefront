using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbProgramaProduto
    {
        public int IdProgramaProduto { get; set; }
        public int IdPrograma { get; set; }
        public int IdProdutoSku { get; set; }
        public string DsPromocao { get; set; }
        public DateTime DtAtualizacao { get; set; }

        public virtual TbProdutoSku IdProdutoSkuNavigation { get; set; }
        public virtual TbPrograma IdProgramaNavigation { get; set; }
    }
}
