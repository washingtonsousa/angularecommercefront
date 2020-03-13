using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class LojaEspecialBanner
    {
        public int IdLojaEspecialBanner { get; set; }
        public int IdLojaEspecial { get; set; }
        public int IdLojaEspecialPosicao { get; set; }
        public bool FlStatus { get; set; }
        public byte NuOrdem { get; set; }
        public string DsArquivo { get; set; }
        public string DsLink { get; set; }
        public string DsArquivoFundo { get; set; }
        public string DsCorFundo { get; set; }

        public virtual LojaEspecial IdLojaEspecialNavigation { get; set; }
        public virtual LojaEspecialPosicao IdLojaEspecialPosicaoNavigation { get; set; }
    }
}
