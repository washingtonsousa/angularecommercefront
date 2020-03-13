using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoAvaliacao
    {
        public int IdProdutoAvaliacao { get; set; }
        public int IdProduto { get; set; }
        public int IdCliente { get; set; }
        public byte FlStatus { get; set; }
        public byte NuAvaliacao { get; set; }
        public DateTime? DtAprovacao { get; set; }
        public DateTime DtCadastro { get; set; }
        public string DsComentario { get; set; }
        public string DsTitulo { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Produto IdProdutoNavigation { get; set; }
    }
}
