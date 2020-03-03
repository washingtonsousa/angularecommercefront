using System.Collections.Generic;

namespace Core.BaseWeb.ViewModel
{
  public class DepartamentoViewModel
  {
    public  ICollection<SessaoViewModel> Sessoes { get; set; }
    public  ProdutoSkuViewModel ProdutoDestaque { get; set; }
    public string NmCategoria { get; set; }
    public int IdCategoria { get; set; }
    public bool FlStatus { get; set; }
    public string CdExterno { get; set; }
    public int NuOrdem { get; set; }
    public string DsHexadecimal { get; set; }
    public string DsImagemDestaque { get; set; }


  }
}
