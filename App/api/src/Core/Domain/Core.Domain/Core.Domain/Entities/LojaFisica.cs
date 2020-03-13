using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class LojaFisica
    {
        public int IdLojaFisica { get; set; }
        public bool FlStatus { get; set; }
        public string NmLojaFisica { get; set; }
        public string DsImagemDestaque { get; set; }
        public string DsSinopse { get; set; }
        public string DsCep { get; set; }
        public string DsEndereco { get; set; }
        public string DsNumero { get; set; }
        public string DsBairro { get; set; }
        public string DsCidade { get; set; }
        public string DsEstado { get; set; }
        public string TxConteudo { get; set; }
        public string DsGoogleMaps { get; set; }
    }
}
