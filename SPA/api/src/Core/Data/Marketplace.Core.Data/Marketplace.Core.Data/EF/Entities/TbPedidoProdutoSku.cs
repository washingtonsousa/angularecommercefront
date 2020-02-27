using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbPedidoProdutoSku
    {
        public TbPedidoProdutoSku()
        {
            TbPedidoProdutoKit = new HashSet<TbPedidoProdutoKit>();
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

        public virtual TbPedido IdPedidoNavigation { get; set; }
        public virtual TbProdutoSku IdProdutoSkuNavigation { get; set; }
        public virtual ICollection<TbPedidoProdutoKit> TbPedidoProdutoKit { get; set; }
    }
}
