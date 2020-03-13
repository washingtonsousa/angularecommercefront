using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Programa
    {
        public Programa()
        {
            ProgramaProduto = new HashSet<ProgramaProduto>();
        }

        public int IdPrograma { get; set; }
        public string CdPrograma { get; set; }
        public string NmPrograma { get; set; }
        public string DsImagem { get; set; }

        public virtual ICollection<ProgramaProduto> ProgramaProduto { get; set; }
    }
}
