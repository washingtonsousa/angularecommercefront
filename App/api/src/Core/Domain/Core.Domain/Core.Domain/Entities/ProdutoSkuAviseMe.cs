using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoSkuAviseMe
    {
        public int IdProdutoSkuAviseMe { get; set; }
        public int IdProdutoSku { get; set; }
        public string DsEmail { get; set; }
        public string DsNome { get; set; }
        public bool FlStatus { get; set; }
        public DateTime DtCadastro { get; set; }
        public int IdPraca { get; set; }

        public virtual ProdutoSku IdProdutoSkuNavigation { get; set; }
    }
}
