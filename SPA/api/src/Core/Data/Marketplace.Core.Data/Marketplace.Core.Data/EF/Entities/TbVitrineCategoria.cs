using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbVitrineCategoria
    {
        public int IdVitrineCategoria { get; set; }
        public int IdVitrine { get; set; }
        public int IdCategoria { get; set; }
        public byte NuOrdem { get; set; }

        public virtual TbCategoria IdCategoriaNavigation { get; set; }
        public virtual TbVitrine IdVitrineNavigation { get; set; }
    }
}
