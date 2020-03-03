﻿using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbPromocaoCliente
    {
        public int IdPromocaoCliente { get; set; }
        public int IdPromocao { get; set; }
        public int IdCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual TbPromocao IdPromocaoNavigation { get; set; }
    }
}
