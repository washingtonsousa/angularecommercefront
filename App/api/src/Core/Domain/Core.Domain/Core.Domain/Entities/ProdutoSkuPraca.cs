using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoSkuPraca
    {
    public ProdutoSkuPraca(int idProdutoSkuPraca, int idProdutoSku, int idPraca,  bool? flPromocao, int nuEstoque, 
      decimal? pcDesconto, decimal vlProdutoSkuDe, decimal vlProdutoSkuPor,
      decimal? vlProdutoSkuPromocaoDe, decimal? vlProdutoSkuPromocaoPor)
    {
      IdProdutoSkuPraca = idProdutoSkuPraca;
      IdProdutoSku = idProdutoSku;
      IdPraca = idPraca;
      FlPromocao = flPromocao;
      NuEstoque = nuEstoque;
      PcDesconto = pcDesconto;
      VlProdutoSkuDe = vlProdutoSkuDe;
      VlProdutoSkuPor = vlProdutoSkuPor;
      VlProdutoSkuPromocaoDe = vlProdutoSkuPromocaoDe;
      VlProdutoSkuPromocaoPor = vlProdutoSkuPromocaoPor;

  }

    public ProdutoSkuPraca() { }

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

        public virtual Praca IdPracaNavigation { get; set; }
        public ProdutoSku IdProdutoSkuNavigation { get; set; }
        public virtual SkuPracaMovimentacao SkuPracaMovimentacao { get; set; }
    }
}
