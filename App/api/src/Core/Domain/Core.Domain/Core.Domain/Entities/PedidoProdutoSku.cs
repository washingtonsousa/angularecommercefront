using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class PedidoProdutoSku
    {
        public PedidoProdutoSku()
        {
            PedidoProdutoKit = new HashSet<PedidoProdutoKit>();
        }

        public int IdPedidoProdutoSku { get; set; }
        public int IdPedido { get; set; }
        public int IdProdutoSku { get; set; }
        public int? IdProdutoCasado { get; set; }
        public bool FlBrinde { get; set; }
        public bool FlEncomenda { get; set; }
        public int NuQuantidade { get; set; }
        public decimal? VlProdutoDe { get; set; }
        public decimal VlProduto { get; set; }
        public decimal? VlEmbalagem { get; set; }
        public decimal? VlDescontoCasada { get; set; }
        public decimal VlDesconto { get; set; }
        public string CdProgramaPbm { get; set; }
        public bool FlPbm { get; set; }
        public decimal PcDescontoPbm { get; set; }
        public bool? FlEstoqueDisponivel { get; set; }

        public virtual Pedido IdPedidoNavigation { get; set; }
        public virtual ProdutoSku IdProdutoSkuNavigation { get; set; }
        public virtual ICollection<PedidoProdutoKit> PedidoProdutoKit { get; set; }
    }
}
