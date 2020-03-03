﻿using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbMensagemProdutoControle
    {
        public int IdMensagemProdutoControle { get; set; }
        public int IdMensagem { get; set; }
        public int IdProdutoControle { get; set; }

        public virtual TbMensagem IdMensagemNavigation { get; set; }
        public virtual TbProdutoControle IdProdutoControleNavigation { get; set; }
    }
}
