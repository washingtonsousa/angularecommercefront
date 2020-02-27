using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbModalidadeEntregaLoja
    {
        public int IdModalidadeEntregaLoja { get; set; }
        public int IdModalidadeEntrega { get; set; }
        public string DsCep { get; set; }
        public string DsEndereco { get; set; }
        public string DsNumero { get; set; }
        public string DsComplemento { get; set; }
        public string DsBairro { get; set; }
        public string DsCidade { get; set; }
        public string DsEstado { get; set; }
        public string DsTelefone { get; set; }

        public virtual TbModalidadeEntrega IdModalidadeEntregaNavigation { get; set; }
    }
}
