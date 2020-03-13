using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ModalidadeEntrega
    {
        public ModalidadeEntrega()
        {
            ModalidadeEntregaAgenda = new HashSet<ModalidadeEntregaAgenda>();
            ModalidadeEntregaCep = new HashSet<ModalidadeEntregaCep>();
            ModalidadeEntregaLoja = new HashSet<ModalidadeEntregaLoja>();
            ModalidadeEntregaRestricao = new HashSet<ModalidadeEntregaRestricao>();
            ProdutoFamiliaModalidade = new HashSet<ProdutoFamiliaModalidade>();
            PromocaoModalidade = new HashSet<PromocaoModalidade>();
        }

        public int IdModalidadeEntrega { get; set; }
        public int IdModalidadeEntregaTipo { get; set; }
        public bool FlStatus { get; set; }
        public bool FlEntregaAgendada { get; set; }
        public string CdExterno { get; set; }
        public decimal VlCubagem { get; set; }
        public string NmModalidadeEntrega { get; set; }
        public string DsMensagem { get; set; }
        public string DsUrlRastreamento { get; set; }
        public bool FlCorreiosAutomatico { get; set; }
        public string CdEmpresaCorreios { get; set; }
        public string DsSenhaCorreios { get; set; }
        public int? IdServicoCorreios { get; set; }
        public bool? FlTotalexpressAutomatico { get; set; }
        public string CdEmpresaTotalexpress { get; set; }
        public string DsSenhaTotalexpress { get; set; }
        public int? IdServicoTotalexpress { get; set; }
        public bool? FlCashondeliveryTotalexpress { get; set; }
        public bool FlUtilizarFaixaCep { get; set; }
        public int? IdPraca { get; set; }
        public bool? FlMaoPropria { get; set; }
        public bool? FlValorDeclarado { get; set; }
        public bool? FlAvisoRecebimento { get; set; }
        public decimal PcSeguro { get; set; }
        public decimal NuIcms { get; set; }

        public virtual Praca IdPracaNavigation { get; set; }
        public virtual ServicoCorreios IdServicoCorreiosNavigation { get; set; }
        public virtual ICollection<ModalidadeEntregaAgenda> ModalidadeEntregaAgenda { get; set; }
        public virtual ICollection<ModalidadeEntregaCep> ModalidadeEntregaCep { get; set; }
        public virtual ICollection<ModalidadeEntregaLoja> ModalidadeEntregaLoja { get; set; }
        public virtual ICollection<ModalidadeEntregaRestricao> ModalidadeEntregaRestricao { get; set; }
        public virtual ICollection<ProdutoFamiliaModalidade> ProdutoFamiliaModalidade { get; set; }
        public virtual ICollection<PromocaoModalidade> PromocaoModalidade { get; set; }
    }
}
