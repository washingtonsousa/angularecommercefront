﻿using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbPracaCep
    {
        public int IdPracaCep { get; set; }
        public int IdPraca { get; set; }
        public string DsCepInicial { get; set; }
        public string DsCepFinal { get; set; }
        public string DsDdd { get; set; }
        public string DsEstado { get; set; }
        public string DsCidade { get; set; }
        public string DsBairro { get; set; }

        public virtual TbPraca IdPracaNavigation { get; set; }
    }
}
