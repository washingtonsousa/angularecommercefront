using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ClienteEnderecoTipo
    {
        public ClienteEnderecoTipo()
        {
            ClienteEndereco = new HashSet<ClienteEndereco>();
        }

        public int IdClienteEnderecoTipo { get; set; }
        public string NmClienteEnderecoTipo { get; set; }

        public virtual ICollection<ClienteEndereco> ClienteEndereco { get; set; }
    }
}
