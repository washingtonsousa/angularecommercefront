using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbClienteEnderecoTipo
    {
        public TbClienteEnderecoTipo()
        {
            TbClienteEndereco = new HashSet<TbClienteEndereco>();
        }

        public int IdClienteEnderecoTipo { get; set; }
        public string NmClienteEnderecoTipo { get; set; }

        public virtual ICollection<TbClienteEndereco> TbClienteEndereco { get; set; }
    }
}
