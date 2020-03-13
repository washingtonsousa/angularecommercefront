using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoSkuEspecificacao
    {
        public int IdProdutoSkuEspecificacao { get; set; }
        public int IdProdutoSku { get; set; }
        public int IdEspecificacao1 { get; set; }
        public int? IdEspecificacao2 { get; set; }

        public virtual Especificacao IdEspecificacao1Navigation { get; set; }
        public virtual Especificacao IdEspecificacao2Navigation { get; set; }
        public virtual ProdutoSku IdProdutoSkuNavigation { get; set; }
    }
}
