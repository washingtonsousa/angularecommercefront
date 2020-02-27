using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbPromocaoMarca
    {
        public int IdPromocaoMarca { get; set; }
        public int IdPromocao { get; set; }
        public int IdMarca { get; set; }

        public virtual TbMarca IdMarcaNavigation { get; set; }
        public virtual TbPromocao IdPromocaoNavigation { get; set; }
    }
}
