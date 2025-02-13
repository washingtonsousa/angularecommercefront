﻿using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class SuperDesconto
    {
        public int IdSuperDesconto { get; set; }
        public int IdProdutoSku { get; set; }
        public int NuOrdem { get; set; }
        public DateTime DtValidadeInicial { get; set; }
        public DateTime DtValidadeFinal { get; set; }

        public virtual ProdutoSku IdProdutoSkuNavigation { get; set; }
    }
}
