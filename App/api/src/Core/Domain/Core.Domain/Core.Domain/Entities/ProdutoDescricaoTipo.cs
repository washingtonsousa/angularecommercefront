using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoDescricaoTipo
    {
        public ProdutoDescricaoTipo()
        {
            ProdutoDescricao = new HashSet<ProdutoDescricao>();
        }

        public int IdProdutoDescricaoTipo { get; set; }
        public bool FlStatus { get; set; }
        public string NmProdutoDescricaoTipo { get; set; }
        public string CdExterno { get; set; }

        public virtual ICollection<ProdutoDescricao> ProdutoDescricao { get; set; }
    }
}
