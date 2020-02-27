using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbPrograma
    {
        public TbPrograma()
        {
            TbProgramaProduto = new HashSet<TbProgramaProduto>();
        }

        public int IdPrograma { get; set; }
        public string CdPrograma { get; set; }
        public string NmPrograma { get; set; }
        public string DsImagem { get; set; }

        public virtual ICollection<TbProgramaProduto> TbProgramaProduto { get; set; }
    }
}
