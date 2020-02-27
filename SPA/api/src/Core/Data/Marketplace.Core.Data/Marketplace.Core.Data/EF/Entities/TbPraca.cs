using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbPraca
    {
        public TbPraca()
        {
            InverseIdPracaPadraoNavigation = new HashSet<TbPraca>();
            TbBannerPraca = new HashSet<TbBannerPraca>();
            TbGatewayPraca = new HashSet<TbGatewayPraca>();
            TbModalidadeEntrega = new HashSet<TbModalidadeEntrega>();
            TbPracaCep = new HashSet<TbPracaCep>();
            TbProdutoSkuPraca = new HashSet<TbProdutoSkuPraca>();
            TbPromocaoPraca = new HashSet<TbPromocaoPraca>();
            TbRodape = new HashSet<TbRodape>();
            TbUsuarioPraca = new HashSet<TbUsuarioPraca>();
            TbVitrinePraca = new HashSet<TbVitrinePraca>();
        }

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

        public virtual TbPraca IdPracaPadraoNavigation { get; set; }
        public virtual ICollection<TbPraca> InverseIdPracaPadraoNavigation { get; set; }
        public virtual ICollection<TbBannerPraca> TbBannerPraca { get; set; }
        public virtual ICollection<TbGatewayPraca> TbGatewayPraca { get; set; }
        public virtual ICollection<TbModalidadeEntrega> TbModalidadeEntrega { get; set; }
        public virtual ICollection<TbPracaCep> TbPracaCep { get; set; }
        public virtual ICollection<TbProdutoSkuPraca> TbProdutoSkuPraca { get; set; }
        public virtual ICollection<TbPromocaoPraca> TbPromocaoPraca { get; set; }
        public virtual ICollection<TbRodape> TbRodape { get; set; }
        public virtual ICollection<TbUsuarioPraca> TbUsuarioPraca { get; set; }
        public virtual ICollection<TbVitrinePraca> TbVitrinePraca { get; set; }
    }
}
