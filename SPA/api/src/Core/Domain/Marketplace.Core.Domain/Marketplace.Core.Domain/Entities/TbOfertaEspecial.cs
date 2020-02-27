using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbOfertaEspecial
    {
        public int IdOfertaEspecial { get; set; }
        public int IdProduto { get; set; }
        public byte NuOrdem { get; set; }

        public virtual TbProduto IdProdutoNavigation { get; set; }
    }
}
