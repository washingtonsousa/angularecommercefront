using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class Categoria
    {
        public Categoria()
        {
            TbBannerCategoria = new HashSet<TbBannerCategoria>();
            TbCategoriaSeo = new HashSet<TbCategoriaSeo>();
            TbMensagemCategoria = new HashSet<TbMensagemCategoria>();
            TbProdutoCategoriaIdCategoriaNavigation = new HashSet<TbProdutoCategoria>();
            TbProdutoCategoriaIdDepartamentoNavigation = new HashSet<TbProdutoCategoria>();
            TbProdutoCategoriaIdSecaoNavigation = new HashSet<TbProdutoCategoria>();
            TbProdutoCategoriaIdSubcategoriaNavigation = new HashSet<TbProdutoCategoria>();
            TbPromocaoCategoriaIdCategoriaNavigation = new HashSet<TbPromocaoCategoria>();
            TbPromocaoCategoriaIdDepartamentoNavigation = new HashSet<TbPromocaoCategoria>();
            TbPromocaoCategoriaIdSecaoNavigation = new HashSet<TbPromocaoCategoria>();
            TbPromocaoCategoriaIdSubcategoriaNavigation = new HashSet<TbPromocaoCategoria>();
            TbVitrineCategoria = new HashSet<TbVitrineCategoria>();
        }

    public virtual ICollection<Categoria> SessoesNavigation { get; set; }
    public virtual TbProdutoSku IdProdutoSkuDestaqueNavigation { get; set; }
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

        public virtual ICollection<TbBannerCategoria> TbBannerCategoria { get; set; }
        public virtual ICollection<TbCategoriaSeo> TbCategoriaSeo { get; set; }
        public virtual ICollection<TbMensagemCategoria> TbMensagemCategoria { get; set; }

        public virtual ICollection<TbProdutoCategoria> TbProdutoCategoriaIdCategoriaNavigation { get; set; }


        public virtual Categoria DepartamentoNavigation { get; set; }
        public virtual ICollection<TbProdutoCategoria> TbProdutoCategoriaIdDepartamentoNavigation { get; set; }
        public virtual ICollection<TbProdutoCategoria> TbProdutoCategoriaIdSecaoNavigation { get; set; }
        public virtual ICollection<TbProdutoCategoria> TbProdutoCategoriaIdSubcategoriaNavigation { get; set; }
        public virtual ICollection<TbPromocaoCategoria> TbPromocaoCategoriaIdCategoriaNavigation { get; set; }
        public virtual ICollection<TbPromocaoCategoria> TbPromocaoCategoriaIdDepartamentoNavigation { get; set; }
        public virtual ICollection<TbPromocaoCategoria> TbPromocaoCategoriaIdSecaoNavigation { get; set; }
        public virtual ICollection<TbPromocaoCategoria> TbPromocaoCategoriaIdSubcategoriaNavigation { get; set; }
        public virtual ICollection<TbVitrineCategoria> TbVitrineCategoria { get; set; }
    }
}
