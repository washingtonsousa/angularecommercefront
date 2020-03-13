using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class VitrineCategoria
    {
        public int IdVitrineCategoria { get; set; }
        public int IdVitrine { get; set; }
        public int IdCategoria { get; set; }
        public byte NuOrdem { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Vitrine IdVitrineNavigation { get; set; }
    }
}
