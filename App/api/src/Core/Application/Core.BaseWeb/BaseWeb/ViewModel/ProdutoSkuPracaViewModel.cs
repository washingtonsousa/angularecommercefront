using Core.Domain.EF.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.BaseWeb.ViewModel
{
  public class ProdutoSkuPracaViewModel
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

    public virtual Praca IdPracaNavigation { get; set; }
    public ProdutoSku IdProdutoSkuNavigation { get; set; }

  }
}
