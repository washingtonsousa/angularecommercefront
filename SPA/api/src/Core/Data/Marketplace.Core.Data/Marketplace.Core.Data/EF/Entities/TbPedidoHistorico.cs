using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbPedidoHistorico
    {
        public int IdPedidoHistorico { get; set; }
        public int IdPedido { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtCadastro { get; set; }
        public string DsHistorico { get; set; }

        public virtual TbPedido IdPedidoNavigation { get; set; }
        public virtual TbUsuario IdUsuarioNavigation { get; set; }
    }
}
