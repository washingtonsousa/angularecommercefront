using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbClienteEndereco
    {
        public int IdClienteEndereco { get; set; }
        public int IdCliente { get; set; }
        public int? IdClienteEnderecoTipo { get; set; }
        public bool FlEnderecoCadastro { get; set; }
        public string NuEndereco { get; set; }
        public string DsCep { get; set; }
        public string DsEndereco { get; set; }
        public string DsBairro { get; set; }
        public string DsCidade { get; set; }
        public string DsEstado { get; set; }
        public string DsComplemento { get; set; }
        public string DsReferencia { get; set; }
        public string DsDestinatario { get; set; }
        public bool? FlRemovido { get; set; }

        public virtual TbClienteEnderecoTipo IdClienteEnderecoTipoNavigation { get; set; }
        public virtual TbCliente IdClienteNavigation { get; set; }
    }
}
