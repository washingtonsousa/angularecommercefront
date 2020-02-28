using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbLojaEspecialSecao
    {
        public TbLojaEspecialSecao()
        {
            TbLojaEspecialCategoria = new HashSet<TbLojaEspecialCategoria>();
            TbLojaEspecialProduto = new HashSet<TbLojaEspecialProduto>();
        }

        public int IdLojaEspecialSecao { get; set; }
        public int IdLojaEspecialDepartamento { get; set; }
        public bool FlStatus { get; set; }
        public byte NuOrdem { get; set; }
        public string NmSecao { get; set; }

        public virtual TbLojaEspecialDepartamento IdLojaEspecialDepartamentoNavigation { get; set; }
        public virtual ICollection<TbLojaEspecialCategoria> TbLojaEspecialCategoria { get; set; }
        public virtual ICollection<TbLojaEspecialProduto> TbLojaEspecialProduto { get; set; }
    }
}
