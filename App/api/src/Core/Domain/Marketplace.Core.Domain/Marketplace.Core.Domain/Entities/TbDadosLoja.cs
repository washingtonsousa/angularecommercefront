using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbDadosLoja
    {
        public int IdDadosLoja { get; set; }
        public string CdGoogleAnalytics { get; set; }
        public int NuLarguraSuper { get; set; }
        public int NuLarguraAmpliada { get; set; }
        public int NuLarguraNormal { get; set; }
        public int NuLarguraCarrossel { get; set; }
        public int NuLarguraMini { get; set; }
        public int NuLarguraVariacao { get; set; }
        public int NuAlturaAmpliada { get; set; }
        public int NuAlturaSuper { get; set; }
        public int NuAlturaNormal { get; set; }
        public int NuAlturaCarrossel { get; set; }
        public int NuAlturaMini { get; set; }
        public int NuAlturaVariacao { get; set; }
        public string NmContato { get; set; }
        public string NmCliente { get; set; }
        public string DsCnpjCpf { get; set; }
        public string DsEndereco { get; set; }
        public string DsCep { get; set; }
        public string DsNumero { get; set; }
        public string DsBairro { get; set; }
        public string DsComplemento { get; set; }
        public string DsCidade { get; set; }
        public string DsEstado { get; set; }
        public string DsTelefone { get; set; }
        public string DsCelular { get; set; }
        public string DsEmailContato { get; set; }
        public string DsTitulo { get; set; }
        public string DsSeoKeywords { get; set; }
        public string DsSeoDescription { get; set; }
        public string DsHorarioAtendimento { get; set; }
        public string DsTelefoneAtendimento { get; set; }
        public string DsCopyright { get; set; }
        public string DsSmtp { get; set; }
        public string DsLoginSmtp { get; set; }
        public string DsSenhaSmtp { get; set; }
        public string DsUrlLoja { get; set; }
        public bool? FlAutocomplete { get; set; }
        public short? NuPorta { get; set; }
        public string DsCriptografiaSmtp { get; set; }
        public string DsClearSaleEntityCode { get; set; }
        public string DsDominio { get; set; }
        public string DsArquivoLogo { get; set; }
        public decimal? VlMinimo { get; set; }
        public decimal? VlMaximo { get; set; }
        public string FlTipoPessoa { get; set; }
        public string DsToken { get; set; }
        public bool? FlFarmacia { get; set; }
        public string DsRoiHero { get; set; }
    }
}
