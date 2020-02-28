using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbProdutoEtiqueta
    {
        public int IdProdutoEtiqueta { get; set; }
        public int IdProduto { get; set; }
        public int IdEtiqueta { get; set; }
        public int? IdPromocao { get; set; }
        public DateTime DtInicial { get; set; }
        public DateTime DtFinal { get; set; }

        public virtual TbEtiqueta IdEtiquetaNavigation { get; set; }
        public virtual TbProduto IdProdutoNavigation { get; set; }
        public virtual TbPromocao IdPromocaoNavigation { get; set; }
    }
}
