using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbProdutoLog
    {
        public int IdProdutoLog { get; set; }
        public int IdProduto { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string DsAcao { get; set; }

        public virtual TbProduto IdProdutoNavigation { get; set; }
        public virtual TbUsuario IdUsuarioNavigation { get; set; }
    }
}
