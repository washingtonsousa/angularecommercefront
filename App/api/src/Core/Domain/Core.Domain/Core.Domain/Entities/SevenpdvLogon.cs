﻿using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class SevenpdvLogon
    {
        public SevenpdvLogon()
        {
            SevenpdvSessao = new HashSet<SevenpdvSessao>();
        }

        public int IdSevenpdvLogon { get; set; }
        public string CdSistema { get; set; }
        public string DsChaveMestre { get; set; }
        public int DsVersaoTabela { get; set; }
        public short DsVersaoInterface { get; set; }
        public bool FlAtivo { get; set; }
        public long? IdOrigem { get; set; }
        public DateTime? DtInclusao { get; set; }
        public int? IdAutorizador { get; set; }

        public virtual ICollection<SevenpdvSessao> SevenpdvSessao { get; set; }
    }
}
