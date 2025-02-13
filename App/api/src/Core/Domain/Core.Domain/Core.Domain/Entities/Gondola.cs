﻿using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Gondola
    {
        public int IdGondola { get; set; }
        public bool FlStatus { get; set; }
        public DateTime DtInicial { get; set; }
        public DateTime DtFinal { get; set; }
        public string NmGondola { get; set; }
        public string DsExibicao { get; set; }
        public int? IdPraca { get; set; }
    }
}
