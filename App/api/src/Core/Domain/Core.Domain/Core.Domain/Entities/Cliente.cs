using Encryption;
using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Cliente
    {
        public Cliente()
        {
            ClienteEndereco = new HashSet<ClienteEndereco>();
            ClienteObservacao = new HashSet<ClienteObservacao>();
            ListaDesejo = new HashSet<ListaDesejo>();
            ProdutoAvaliacao = new HashSet<ProdutoAvaliacao>();
            PromocaoCliente = new HashSet<PromocaoCliente>();
            PromocaoCupomUtilizado = new HashSet<PromocaoCupomUtilizado>();
        }

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
        public bool FlNovo { get; set; }
        public bool FlMarketing { get; set; }
        public DateTime? DtMarketingImp { get; set; }

        public virtual ICollection<ClienteEndereco> ClienteEndereco { get; set; }
        public virtual ICollection<ClienteObservacao> ClienteObservacao { get; set; }
        public virtual ICollection<ListaDesejo> ListaDesejo { get; set; }
        public virtual ICollection<ProdutoAvaliacao> ProdutoAvaliacao { get; set; }
        public virtual ICollection<PromocaoCliente> PromocaoCliente { get; set; }
        public virtual ICollection<PromocaoCupomUtilizado> PromocaoCupomUtilizado { get; set; }

    /// <summary>
    /// Método de Domínio - Atualização
    /// </summary>
    /// <param name="cliente"></param>
    public void Update(Cliente cliente)
    {
      DsCelularDdd = cliente.DsCelularDdd;
      DsCelular = cliente.DsCelular;
      DsTelefone = cliente.DsTelefone;
      DsTelefoneDdd = cliente.DsCelularDdd;
      DsRg = cliente.DsRg;
      NomeSocial = cliente.NomeSocial;
      DtNascimento = cliente.DtNascimento;
      FlAceitaMailing = cliente.FlAceitaMailing;
    }

    public Cliente PrepareForSubscription() {

      DsSenha = Crypto.ActionEncrypt(DsSenha);

        return this;

    }

  }
}
