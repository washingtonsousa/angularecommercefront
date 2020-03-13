using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class LojaEspecialVitrineProduto
    {
        public int IdLojaEspecialVitrineProduto { get; set; }
        public int IdLojaEspecialVitrine { get; set; }
        public int IdProduto { get; set; }
        public byte NuOrdem { get; set; }

        public virtual LojaEspecialVitrine IdLojaEspecialVitrineNavigation { get; set; }
        public virtual Produto IdProdutoNavigation { get; set; }
    }
}
