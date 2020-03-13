using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoLog
    {
        public int IdProdutoLog { get; set; }
        public int IdProduto { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string DsAcao { get; set; }

        public virtual Produto IdProdutoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
