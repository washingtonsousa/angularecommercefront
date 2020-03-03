﻿using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbMensagemProdutoTipo
    {
        public int IdMensagemProdutoTipo { get; set; }
        public int IdMensagem { get; set; }
        public int IdProdutoTipo { get; set; }

        public virtual TbMensagem IdMensagemNavigation { get; set; }
        public virtual TbProdutoTipo IdProdutoTipoNavigation { get; set; }
    }
}
