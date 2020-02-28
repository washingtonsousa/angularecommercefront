using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbLojaEspecial
    {
        public TbLojaEspecial()
        {
            TbLojaEspecialBanner = new HashSet<TbLojaEspecialBanner>();
            TbLojaEspecialDepartamento = new HashSet<TbLojaEspecialDepartamento>();
            TbLojaEspecialMarca = new HashSet<TbLojaEspecialMarca>();
            TbLojaEspecialProduto = new HashSet<TbLojaEspecialProduto>();
            TbLojaEspecialVitrine = new HashSet<TbLojaEspecialVitrine>();
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

        public virtual ICollection<TbLojaEspecialBanner> TbLojaEspecialBanner { get; set; }
        public virtual ICollection<TbLojaEspecialDepartamento> TbLojaEspecialDepartamento { get; set; }
        public virtual ICollection<TbLojaEspecialMarca> TbLojaEspecialMarca { get; set; }
        public virtual ICollection<TbLojaEspecialProduto> TbLojaEspecialProduto { get; set; }
        public virtual ICollection<TbLojaEspecialVitrine> TbLojaEspecialVitrine { get; set; }
    }
}
