using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
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

        public virtual Pedido IdPedidoNavigation { get; set; }
        public virtual TbPedidoStatus IdPedidoStatusAnteriorNavigation { get; set; }
        public virtual TbPedidoStatus IdPedidoStatusAtualNavigation { get; set; }
        public virtual TbUsuario IdUsuarioNavigation { get; set; }
    }
}
