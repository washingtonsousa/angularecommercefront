using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbPedidoLog
    {
        public int IdPedidoLog { get; set; }
        public int IdPedidoStatusAnterior { get; set; }
        public int IdPedidoStatusAtual { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime DtCadastro { get; set; }
        public string DsOrigem { get; set; }
        public int IdPedido { get; set; }

        public virtual TbPedido IdPedidoNavigation { get; set; }
        public virtual TbPedidoStatus IdPedidoStatusAnteriorNavigation { get; set; }
        public virtual TbPedidoStatus IdPedidoStatusAtualNavigation { get; set; }
        public virtual TbUsuario IdUsuarioNavigation { get; set; }
    }
}
