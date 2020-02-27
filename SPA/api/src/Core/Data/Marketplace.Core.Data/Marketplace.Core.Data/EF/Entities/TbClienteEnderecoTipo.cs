using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
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
