using System;
using System.Collections.Generic;
using System.Text;

namespace Core.BaseWeb.ViewModel
{
  public class PracaViewModel
  {
    public int IdPraca { get; set; }
    public bool FlPadrao { get; set; }
    public string NmPraca { get; set; }
    public string CdExterno { get; set; }
    public DateTime? DtUltimoPedido { get; set; }
    public string DsEndereco { get; set; }
    public string NuEndereco { get; set; }
    public string DsCep { get; set; }
    public string DsBairro { get; set; }
    public string DsCidade { get; set; }
    public string DsComplemento { get; set; }
    public string DsTelefone { get; set; }
    public string DsEmail { get; set; }
    public string DsHorarioAtendimento { get; set; }
    public string DsEstado { get; set; }
    public int? IdPracaPadrao { get; set; }
    public bool FlAtivo { get; set; }
    public bool FlInicial { get; set; }
    public string DsArquivoLogo { get; set; }
    public bool? FlExibeFrontend { get; set; }
    public string DsWhatsapp { get; set; }
    public string DsAlias { get; set; }
  }
}
