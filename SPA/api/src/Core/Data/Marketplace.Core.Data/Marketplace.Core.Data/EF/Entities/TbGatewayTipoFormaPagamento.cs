﻿using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbGatewayTipoFormaPagamento
    {
        public int IdGatewayTipoFormaPagamento { get; set; }
        public int IdGatewayTipo { get; set; }
        public int IdFormaPagamento { get; set; }

        public virtual TbFormaPagamento IdFormaPagamentoNavigation { get; set; }
        public virtual TbGatewayTipo IdGatewayTipoNavigation { get; set; }
    }
}
