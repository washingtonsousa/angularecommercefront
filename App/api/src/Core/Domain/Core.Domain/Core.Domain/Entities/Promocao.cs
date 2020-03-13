using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Promocao
    {
        public Promocao()
        {
            ProdutoEtiqueta = new HashSet<ProdutoEtiqueta>();
            PromocaoCategoria = new HashSet<PromocaoCategoria>();
            PromocaoCep = new HashSet<PromocaoCep>();
            PromocaoCliente = new HashSet<PromocaoCliente>();
            PromocaoCupom = new HashSet<PromocaoCupom>();
            PromocaoMarca = new HashSet<PromocaoMarca>();
            PromocaoModalidade = new HashSet<PromocaoModalidade>();
            PromocaoPagamento = new HashSet<PromocaoPagamento>();
            PromocaoPraca = new HashSet<PromocaoPraca>();
            PromocaoProduto = new HashSet<PromocaoProduto>();
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

        public virtual Etiqueta IdEtiquetaNavigation { get; set; }
        public virtual PromocaoAcao IdPromocaoAcaoNavigation { get; set; }
        public virtual PromocaoBeneficio IdPromocaoBeneficioNavigation { get; set; }
        public virtual PromocaoTipo IdPromocaoTipoNavigation { get; set; }
        public virtual ICollection<ProdutoEtiqueta> ProdutoEtiqueta { get; set; }
        public virtual ICollection<PromocaoCategoria> PromocaoCategoria { get; set; }
        public virtual ICollection<PromocaoCep> PromocaoCep { get; set; }
        public virtual ICollection<PromocaoCliente> PromocaoCliente { get; set; }
        public virtual ICollection<PromocaoCupom> PromocaoCupom { get; set; }
        public virtual ICollection<PromocaoMarca> PromocaoMarca { get; set; }
        public virtual ICollection<PromocaoModalidade> PromocaoModalidade { get; set; }
        public virtual ICollection<PromocaoPagamento> PromocaoPagamento { get; set; }
        public virtual ICollection<PromocaoPraca> PromocaoPraca { get; set; }
        public virtual ICollection<PromocaoProduto> PromocaoProduto { get; set; }
    }
}
