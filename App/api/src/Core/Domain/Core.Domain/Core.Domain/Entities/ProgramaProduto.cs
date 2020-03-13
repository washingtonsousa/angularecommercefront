using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProgramaProduto
    {
        public int IdProgramaProduto { get; set; }
        public int IdPrograma { get; set; }
        public int IdProdutoSku { get; set; }
        public string DsPromocao { get; set; }
        public DateTime DtAtualizacao { get; set; }

        public virtual ProdutoSku IdProdutoSkuNavigation { get; set; }
        public virtual Programa IdProgramaNavigation { get; set; }
    }
}
