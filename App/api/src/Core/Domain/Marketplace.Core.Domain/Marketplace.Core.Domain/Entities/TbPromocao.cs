using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbPromocao
    {
        public TbPromocao()
        {
            TbProdutoEtiqueta = new HashSet<TbProdutoEtiqueta>();
            TbPromocaoCategoria = new HashSet<TbPromocaoCategoria>();
            TbPromocaoCep = new HashSet<TbPromocaoCep>();
            TbPromocaoCliente = new HashSet<TbPromocaoCliente>();
            TbPromocaoCupom = new HashSet<TbPromocaoCupom>();
            TbPromocaoMarca = new HashSet<TbPromocaoMarca>();
            TbPromocaoModalidade = new HashSet<TbPromocaoModalidade>();
            TbPromocaoPagamento = new HashSet<TbPromocaoPagamento>();
            TbPromocaoPraca = new HashSet<TbPromocaoPraca>();
            TbPromocaoProduto = new HashSet<TbPromocaoProduto>();
        }

        public int IdPromocao { get; set; }
        public int IdPromocaoBeneficio { get; set; }
        public int IdPromocaoTipo { get; set; }
        public int IdPromocaoAcao { get; set; }
        public int? IdEtiqueta { get; set; }
        public int? IdProdutoBrinde { get; set; }
        public bool FlStatus { get; set; }
        public bool FlGeraCupomAutomatico { get; set; }
        public decimal? VlDesconto { get; set; }
        public decimal? VlMinimoPedido { get; set; }
        public decimal? NuPesoMaximo { get; set; }
        public DateTime DtInicial { get; set; }
        public DateTime DtFinal { get; set; }
        public string NmPromocao { get; set; }

        public virtual TbEtiqueta IdEtiquetaNavigation { get; set; }
        public virtual TbPromocaoAcao IdPromocaoAcaoNavigation { get; set; }
        public virtual TbPromocaoBeneficio IdPromocaoBeneficioNavigation { get; set; }
        public virtual TbPromocaoTipo IdPromocaoTipoNavigation { get; set; }
        public virtual ICollection<TbProdutoEtiqueta> TbProdutoEtiqueta { get; set; }
        public virtual ICollection<TbPromocaoCategoria> TbPromocaoCategoria { get; set; }
        public virtual ICollection<TbPromocaoCep> TbPromocaoCep { get; set; }
        public virtual ICollection<TbPromocaoCliente> TbPromocaoCliente { get; set; }
        public virtual ICollection<TbPromocaoCupom> TbPromocaoCupom { get; set; }
        public virtual ICollection<TbPromocaoMarca> TbPromocaoMarca { get; set; }
        public virtual ICollection<TbPromocaoModalidade> TbPromocaoModalidade { get; set; }
        public virtual ICollection<TbPromocaoPagamento> TbPromocaoPagamento { get; set; }
        public virtual ICollection<TbPromocaoPraca> TbPromocaoPraca { get; set; }
        public virtual ICollection<TbPromocaoProduto> TbPromocaoProduto { get; set; }
    }
}
