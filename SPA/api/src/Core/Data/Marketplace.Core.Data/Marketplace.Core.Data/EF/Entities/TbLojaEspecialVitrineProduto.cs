using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbLojaEspecialVitrineProduto
    {
        public int IdLojaEspecialVitrineProduto { get; set; }
        public int IdLojaEspecialVitrine { get; set; }
        public int IdProduto { get; set; }
        public byte NuOrdem { get; set; }

        public virtual TbLojaEspecialVitrine IdLojaEspecialVitrineNavigation { get; set; }
        public virtual TbProduto IdProdutoNavigation { get; set; }
    }
}
