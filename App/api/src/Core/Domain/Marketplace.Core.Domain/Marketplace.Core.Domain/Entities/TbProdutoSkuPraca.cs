using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbProdutoSkuPraca
    {
        public int IdProdutoSkuPraca { get; set; }
        public int IdProdutoSku { get; set; }
        public int IdPraca { get; set; }
        public bool FlStatus { get; set; }
        public bool? FlPromocao { get; set; }
        public int NuEstoque { get; set; }
        public int NuEstoqueMinimo { get; set; }
        public int NuPrazoPostagem { get; set; }
        public decimal? PcDesconto { get; set; }
        public DateTime? DtInicioPromocao { get; set; }
        public DateTime? DtFimPromocao { get; set; }
        public decimal VlProdutoSkuDe { get; set; }
        public decimal VlProdutoSkuPor { get; set; }
        public decimal? VlProdutoSkuPromocaoDe { get; set; }
        public decimal? VlProdutoSkuPromocaoPor { get; set; }
        public decimal? VlEmbalagemPresente { get; set; }

        public virtual TbPraca IdPracaNavigation { get; set; }
        public virtual ProdutoSku IdProdutoSkuNavigation { get; set; }
        public virtual TbSkuPracaMovimentacao TbSkuPracaMovimentacao { get; set; }
    }
}
