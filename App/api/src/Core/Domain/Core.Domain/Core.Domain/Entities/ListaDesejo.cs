using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ListaDesejo
    {
        public ListaDesejo()
        {
            ListaDesejoProdutoSku = new HashSet<ListaDesejoProdutoSku>();
        }

        public int IdListaDesejo { get; set; }
        public int IdListaDesejoPeriodo { get; set; }
        public int IdCliente { get; set; }
        public bool FlStatus { get; set; }
        public string NmListaDesejo { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual ListaDesejoPeriodo IdListaDesejoPeriodoNavigation { get; set; }
        public virtual ICollection<ListaDesejoProdutoSku> ListaDesejoProdutoSku { get; set; }
    }
}
