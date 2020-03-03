using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbFiltro
    {
        public TbFiltro()
        {
            TbProdutoSkuFiltro = new HashSet<TbProdutoSkuFiltro>();
        }

        public int IdFiltro { get; set; }
        public int IdFiltroTipo { get; set; }
        public bool FlStatus { get; set; }
        public byte NuOrdem { get; set; }
        public string NmFiltro { get; set; }
        public string CdExterno { get; set; }
        public bool? FlExibeProduto { get; set; }
        public bool? FlExibeCategoria { get; set; }

        public virtual TbFiltroTipo IdFiltroTipoNavigation { get; set; }
        public virtual ICollection<TbProdutoSkuFiltro> TbProdutoSkuFiltro { get; set; }
    }
}
