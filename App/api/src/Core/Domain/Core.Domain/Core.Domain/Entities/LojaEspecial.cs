using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class LojaEspecial
    {
        public LojaEspecial()
        {
            LojaEspecialBanner = new HashSet<LojaEspecialBanner>();
            LojaEspecialDepartamento = new HashSet<LojaEspecialDepartamento>();
            LojaEspecialMarca = new HashSet<LojaEspecialMarca>();
            LojaEspecialProduto = new HashSet<LojaEspecialProduto>();
            LojaEspecialVitrine = new HashSet<LojaEspecialVitrine>();
        }

        public int IdLojaEspecial { get; set; }
        public bool FlExibeHtml { get; set; }
        public bool FlStatus { get; set; }
        public bool FlExibeCategorizacaoAuto { get; set; }
        public byte NuOrdem { get; set; }
        public string NmLojaEspecial { get; set; }
        public string DsCor1 { get; set; }
        public string DsCor2 { get; set; }
        public string DsArquivoLogo { get; set; }
        public string DsCorFundo { get; set; }
        public string DsSkinFundo { get; set; }
        public string DsSkinRepeat { get; set; }
        public string TxHtml { get; set; }

        public virtual ICollection<LojaEspecialBanner> LojaEspecialBanner { get; set; }
        public virtual ICollection<LojaEspecialDepartamento> LojaEspecialDepartamento { get; set; }
        public virtual ICollection<LojaEspecialMarca> LojaEspecialMarca { get; set; }
        public virtual ICollection<LojaEspecialProduto> LojaEspecialProduto { get; set; }
        public virtual ICollection<LojaEspecialVitrine> LojaEspecialVitrine { get; set; }
    }
}
