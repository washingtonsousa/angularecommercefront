using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbListaDesejo
    {
        public TbListaDesejo()
        {
            TbListaDesejoProdutoSku = new HashSet<TbListaDesejoProdutoSku>();
        }

        public int IdListaDesejo { get; set; }
        public int IdListaDesejoPeriodo { get; set; }
        public int IdCliente { get; set; }
        public bool FlStatus { get; set; }
        public string NmListaDesejo { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; }
        public virtual TbListaDesejoPeriodo IdListaDesejoPeriodoNavigation { get; set; }
        public virtual ICollection<TbListaDesejoProdutoSku> TbListaDesejoProdutoSku { get; set; }
    }
}
