using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoEtiqueta
    {
        public int IdProdutoEtiqueta { get; set; }
        public int IdProduto { get; set; }
        public int IdEtiqueta { get; set; }
        public int? IdPromocao { get; set; }
        public DateTime DtInicial { get; set; }
        public DateTime DtFinal { get; set; }

        public virtual Etiqueta IdEtiquetaNavigation { get; set; }
        public virtual Produto IdProdutoNavigation { get; set; }
        public virtual Promocao IdPromocaoNavigation { get; set; }
    }
}
