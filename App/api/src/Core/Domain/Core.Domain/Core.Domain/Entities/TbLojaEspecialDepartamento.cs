using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbLojaEspecialDepartamento
    {
        public TbLojaEspecialDepartamento()
        {
            TbLojaEspecialProduto = new HashSet<TbLojaEspecialProduto>();
            TbLojaEspecialSecao = new HashSet<TbLojaEspecialSecao>();
        }

        public int IdLojaEspecialDepartamento { get; set; }
        public int IdLojaEspecial { get; set; }
        public bool FlStatus { get; set; }
        public byte NuOrdem { get; set; }
        public string NmDepartamento { get; set; }

        public virtual TbLojaEspecial IdLojaEspecialNavigation { get; set; }
        public virtual ICollection<TbLojaEspecialProduto> TbLojaEspecialProduto { get; set; }
        public virtual ICollection<TbLojaEspecialSecao> TbLojaEspecialSecao { get; set; }
    }
}
