using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Email
    {
        public int IdEmail { get; set; }
        public int IdEmailTipo { get; set; }
        public int? IdPedidoStatus { get; set; }
        public DateTime DtCadastro { get; set; }
        public string NmRemetente { get; set; }
        public string DsEmailRemetente { get; set; }
        public string DsAssunto { get; set; }
        public string TxConteudo { get; set; }

        public virtual EmailTipo IdEmailTipoNavigation { get; set; }
        public virtual PedidoStatus IdPedidoStatusNavigation { get; set; }
    }
}
