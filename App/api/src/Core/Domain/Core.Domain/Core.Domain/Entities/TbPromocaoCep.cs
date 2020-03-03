using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbPromocaoCep
    {
        public int IdPromocaoCep { get; set; }
        public int IdPromocao { get; set; }
        public string DsCepInicial { get; set; }
        public string DsCepFinal { get; set; }
        public string DsEstado { get; set; }
        public string DsCidade { get; set; }
        public string DsBairro { get; set; }

        public virtual TbPromocao IdPromocaoNavigation { get; set; }
    }
}
