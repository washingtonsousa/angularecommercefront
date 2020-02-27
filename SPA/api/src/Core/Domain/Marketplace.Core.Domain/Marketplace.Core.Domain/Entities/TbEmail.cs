using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbEmail
    {
        public int IdEmail { get; set; }
        public int IdEmailTipo { get; set; }
        public int? IdPedidoStatus { get; set; }
        public DateTime DtCadastro { get; set; }
        public string NmRemetente { get; set; }
        public string DsEmailRemetente { get; set; }
        public string DsAssunto { get; set; }
        public string TxConteudo { get; set; }

        public virtual TbEmailTipo IdEmailTipoNavigation { get; set; }
        public virtual TbPedidoStatus IdPedidoStatusNavigation { get; set; }
    }
}
