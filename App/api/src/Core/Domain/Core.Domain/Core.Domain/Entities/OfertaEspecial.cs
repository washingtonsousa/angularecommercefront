using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class OfertaEspecial
    {
        public int IdOfertaEspecial { get; set; }
        public int IdProduto { get; set; }
        public byte NuOrdem { get; set; }

        public virtual Produto IdProdutoNavigation { get; set; }
    }
}
