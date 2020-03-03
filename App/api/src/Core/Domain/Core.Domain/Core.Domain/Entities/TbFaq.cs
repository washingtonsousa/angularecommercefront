using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class TbFaq
    {
        public int IdFaq { get; set; }
        public int IdFaqCategoria { get; set; }
        public bool FlStatus { get; set; }
        public string DsPergunta { get; set; }
        public string TxResposta { get; set; }

        public virtual TbFaqCategoria IdFaqCategoriaNavigation { get; set; }
    }
}
