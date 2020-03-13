using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ClienteObservacao
    {
        public int IdClienteObservacao { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtCadastro { get; set; }
        public string DsObservacao { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
