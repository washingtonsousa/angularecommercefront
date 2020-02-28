using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbClienteObservacao
    {
        public int IdClienteObservacao { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtCadastro { get; set; }
        public string DsObservacao { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; }
        public virtual TbUsuario IdUsuarioNavigation { get; set; }
    }
}
