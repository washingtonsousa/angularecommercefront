﻿using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ClienteEndereco
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

        public virtual ClienteEnderecoTipo IdClienteEnderecoTipoNavigation { get; set; }
        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
