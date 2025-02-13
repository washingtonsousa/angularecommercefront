﻿using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PedidoGestaoRisco
    {
        public int IdGestaoRisco { get; set; }
        public int IdPedido { get; set; }
        public string DsTransacao { get; set; }
        public string DsStatus { get; set; }
        public string DsScore { get; set; }
        public string DsMetodoComunicacao { get; set; }
        public string DsXmlRetorno { get; set; }
        public string DsSessionId { get; set; }
        public string DsStatusCode { get; set; }
        public string DsMensagem { get; set; }
        public DateTime DtOcorrencia { get; set; }
        public bool FlEnviado { get; set; }
    }
}
