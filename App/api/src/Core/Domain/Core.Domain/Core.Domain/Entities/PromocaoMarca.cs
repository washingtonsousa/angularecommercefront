using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PromocaoMarca
    {
        public int IdPromocaoMarca { get; set; }
        public int IdPromocao { get; set; }
        public int IdMarca { get; set; }

        public virtual Marca IdMarcaNavigation { get; set; }
        public virtual Promocao IdPromocaoNavigation { get; set; }
    }
}
