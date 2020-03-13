using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Categoria
    {
        public Categoria()
        {
            BannerCategoria = new HashSet<BannerCategoria>();
            CategoriaSeo = new HashSet<CategoriaSeo>();
            MensagemCategoria = new HashSet<MensagemCategoria>();
            ProdutoCategoriaIdCategoriaNavigation = new HashSet<ProdutoCategoria>();
            ProdutoCategoriaIdDepartamentoNavigation = new HashSet<ProdutoCategoria>();
            ProdutoCategoriaIdSecaoNavigation = new HashSet<ProdutoCategoria>();
            ProdutoCategoriaIdSubcategoriaNavigation = new HashSet<ProdutoCategoria>();
            PromocaoCategoriaIdCategoriaNavigation = new HashSet<PromocaoCategoria>();
            PromocaoCategoriaIdDepartamentoNavigation = new HashSet<PromocaoCategoria>();
            PromocaoCategoriaIdSecaoNavigation = new HashSet<PromocaoCategoria>();
            PromocaoCategoriaIdSubcategoriaNavigation = new HashSet<PromocaoCategoria>();
            VitrineCategoria = new HashSet<VitrineCategoria>();
        }

    public virtual ICollection<Categoria> SessoesNavigation { get; set; }
    public virtual ProdutoSku IdProdutoSkuDestaqueNavigation { get; set; }
    public string NmCategoria { get; set; }

    public int IdCategoria { get; set; }
        public int? IdCategoriaPai { get; set; }
        public int? IdProdutoSkuDestaque { get; set; }
        public bool FlStatus { get; set; }
        public string CdExterno { get; set; }
        public int NuOrdem { get; set; }
        public DateTime DtCadastro { get; set; }
        public string DsHexadecimal { get; set; }
        public string DsImagemDestaque { get; set; }
        public int? IdCategoriaVannon { get; set; }

        public virtual ICollection<BannerCategoria> BannerCategoria { get; set; }
        public virtual ICollection<CategoriaSeo> CategoriaSeo { get; set; }
        public virtual ICollection<MensagemCategoria> MensagemCategoria { get; set; }

        public virtual ICollection<ProdutoCategoria> ProdutoCategoriaIdCategoriaNavigation { get; set; }


        public virtual Categoria DepartamentoNavigation { get; set; }
        public virtual ICollection<ProdutoCategoria> ProdutoCategoriaIdDepartamentoNavigation { get; set; }
        public virtual ICollection<ProdutoCategoria> ProdutoCategoriaIdSecaoNavigation { get; set; }
        public virtual ICollection<ProdutoCategoria> ProdutoCategoriaIdSubcategoriaNavigation { get; set; }
        public virtual ICollection<PromocaoCategoria> PromocaoCategoriaIdCategoriaNavigation { get; set; }
        public virtual ICollection<PromocaoCategoria> PromocaoCategoriaIdDepartamentoNavigation { get; set; }
        public virtual ICollection<PromocaoCategoria> PromocaoCategoriaIdSecaoNavigation { get; set; }
        public virtual ICollection<PromocaoCategoria> PromocaoCategoriaIdSubcategoriaNavigation { get; set; }
        public virtual ICollection<VitrineCategoria> VitrineCategoria { get; set; }
    }
}
