using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ListaDesejoProdutoSku
    {
        public int IdListaDesejoProdutoSku { get; set; }
        public int IdListaDesejo { get; set; }
        public int IdProdutoSku { get; set; }

        public virtual ListaDesejo IdListaDesejoNavigation { get; set; }
        public virtual ProdutoSku IdProdutoSkuNavigation { get; set; }
    }
}
