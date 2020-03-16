using Encryption;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Core.BaseWeb.ViewModel
{
  public class ClienteViewModel
  {
    // AutoMapper Ignora, pois serve apenas para retorno da autenticação
    public string Token { get; set; }
    public int IdCliente { get; set; }
    public bool FlStatus { get; set; }
    public string FlTipoPessoa { get; set; }
    public bool? FlIeIsento { get; set; }
    public string FlSexo { get; set; }
    public bool FlAceitaMailing { get; set; }
    public bool FlAceitaSms { get; set; }
    public string CdExterno { get; set; }
    public DateTime DtCadastro { get; set; }
    public DateTime? DtNascimento { get; set; }
    public string NmCliente { get; set; }
    public string DsApelido { get; set; }
    public string DsCpfCnpj { get; set; }
    public string DsRg { get; set; }
    public string DsRazaoSocial { get; set; }
    public string DsInscricaoEstadual { get; set; }
    public string DsSobrenome { get; set; }
    public string DsResponsavel { get; set; }
    public string DsEmail { get; set; }
    public string DsSenha { get; set; }
    public string DsTelefoneDdd { get; set; }
    public string DsTelefone { get; set; }
    public string DsCelularDdd { get; set; }
    public string DsCelular { get; set; }
    public string FlIntegracao { get; set; }
    public string NomeSocial { get; set; }


    public ClienteViewModel GetWithoutPassWord
    {
      get
      {
        var obj = this;
        obj.DsSenha = null;
        return obj;
      }
    }

    

    

  }
}
