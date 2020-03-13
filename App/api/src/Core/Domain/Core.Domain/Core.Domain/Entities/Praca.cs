using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Praca
    {
        public Praca()
        {
            InverseIdPracaPadraoNavigation = new HashSet<Praca>();
            BannerPraca = new HashSet<BannerPraca>();
            GatewayPraca = new HashSet<GatewayPraca>();
            ModalidadeEntrega = new HashSet<ModalidadeEntrega>();
            PracaCep = new HashSet<PracaCep>();
            ProdutoSkuPraca = new HashSet<ProdutoSkuPraca>();
            PromocaoPraca = new HashSet<PromocaoPraca>();
            Rodape = new HashSet<Rodape>();
            UsuarioPraca = new HashSet<UsuarioPraca>();
            VitrinePraca = new HashSet<VitrinePraca>();
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

        public virtual Praca IdPracaPadraoNavigation { get; set; }
        public virtual ICollection<Praca> InverseIdPracaPadraoNavigation { get; set; }
        public virtual ICollection<BannerPraca> BannerPraca { get; set; }
        public virtual ICollection<GatewayPraca> GatewayPraca { get; set; }
        public virtual ICollection<ModalidadeEntrega> ModalidadeEntrega { get; set; }
        public virtual ICollection<PracaCep> PracaCep { get; set; }
        public virtual ICollection<ProdutoSkuPraca> ProdutoSkuPraca { get; set; }
        public virtual ICollection<PromocaoPraca> PromocaoPraca { get; set; }
        public virtual ICollection<Rodape> Rodape { get; set; }
        public virtual ICollection<UsuarioPraca> UsuarioPraca { get; set; }
        public virtual ICollection<VitrinePraca> VitrinePraca { get; set; }
    }
}
