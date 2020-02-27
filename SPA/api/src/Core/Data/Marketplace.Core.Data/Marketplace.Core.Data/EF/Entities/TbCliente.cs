using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbCliente
    {
        public TbCliente()
        {
            TbClienteEndereco = new HashSet<TbClienteEndereco>();
            TbClienteObservacao = new HashSet<TbClienteObservacao>();
            TbListaDesejo = new HashSet<TbListaDesejo>();
            TbProdutoAvaliacao = new HashSet<TbProdutoAvaliacao>();
            TbPromocaoCliente = new HashSet<TbPromocaoCliente>();
            TbPromocaoCupomUtilizado = new HashSet<TbPromocaoCupomUtilizado>();
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

        public virtual ICollection<TbClienteEndereco> TbClienteEndereco { get; set; }
        public virtual ICollection<TbClienteObservacao> TbClienteObservacao { get; set; }
        public virtual ICollection<TbListaDesejo> TbListaDesejo { get; set; }
        public virtual ICollection<TbProdutoAvaliacao> TbProdutoAvaliacao { get; set; }
        public virtual ICollection<TbPromocaoCliente> TbPromocaoCliente { get; set; }
        public virtual ICollection<TbPromocaoCupomUtilizado> TbPromocaoCupomUtilizado { get; set; }
    }
}
