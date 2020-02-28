using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbProdutoDescricaoTipo
    {
        public TbProdutoDescricaoTipo()
        {
            TbProdutoDescricao = new HashSet<TbProdutoDescricao>();
        }

        public int IdProdutoDescricaoTipo { get; set; }
        public bool FlStatus { get; set; }
        public string NmProdutoDescricaoTipo { get; set; }
        public string CdExterno { get; set; }

        public virtual ICollection<TbProdutoDescricao> TbProdutoDescricao { get; set; }
    }
}
