using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbNewsletter
    {
        public int IdNewsletter { get; set; }
        public bool FlStatus { get; set; }
        public DateTime DtCadastro { get; set; }
        public string NmContato { get; set; }
        public string DsEmail { get; set; }
    }
}
