using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbModalidadeEntrega
    {
        public TbModalidadeEntrega()
        {
            TbModalidadeEntregaAgenda = new HashSet<TbModalidadeEntregaAgenda>();
            TbModalidadeEntregaCep = new HashSet<TbModalidadeEntregaCep>();
            TbModalidadeEntregaLoja = new HashSet<TbModalidadeEntregaLoja>();
            TbModalidadeEntregaRestricao = new HashSet<TbModalidadeEntregaRestricao>();
            TbProdutoFamiliaModalidade = new HashSet<TbProdutoFamiliaModalidade>();
            TbPromocaoModalidade = new HashSet<TbPromocaoModalidade>();
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

        public virtual TbPraca IdPracaNavigation { get; set; }
        public virtual TbServicoCorreios IdServicoCorreiosNavigation { get; set; }
        public virtual ICollection<TbModalidadeEntregaAgenda> TbModalidadeEntregaAgenda { get; set; }
        public virtual ICollection<TbModalidadeEntregaCep> TbModalidadeEntregaCep { get; set; }
        public virtual ICollection<TbModalidadeEntregaLoja> TbModalidadeEntregaLoja { get; set; }
        public virtual ICollection<TbModalidadeEntregaRestricao> TbModalidadeEntregaRestricao { get; set; }
        public virtual ICollection<TbProdutoFamiliaModalidade> TbProdutoFamiliaModalidade { get; set; }
        public virtual ICollection<TbPromocaoModalidade> TbPromocaoModalidade { get; set; }
    }
}
