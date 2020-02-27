using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbMensagem
    {
        public TbMensagem()
        {
            TbMensagemCategoria = new HashSet<TbMensagemCategoria>();
            TbMensagemMarca = new HashSet<TbMensagemMarca>();
            TbMensagemPrincipioAtivo = new HashSet<TbMensagemPrincipioAtivo>();
            TbMensagemProdutoControle = new HashSet<TbMensagemProdutoControle>();
            TbMensagemProdutoFamilia = new HashSet<TbMensagemProdutoFamilia>();
            TbMensagemProdutoTipo = new HashSet<TbMensagemProdutoTipo>();
        }

        public int IdMensagem { get; set; }
        public string CdExterno { get; set; }
        public bool FlStatus { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
        public string DsMensagem { get; set; }
        public string DsTitulo { get; set; }

        public virtual ICollection<TbMensagemCategoria> TbMensagemCategoria { get; set; }
        public virtual ICollection<TbMensagemMarca> TbMensagemMarca { get; set; }
        public virtual ICollection<TbMensagemPrincipioAtivo> TbMensagemPrincipioAtivo { get; set; }
        public virtual ICollection<TbMensagemProdutoControle> TbMensagemProdutoControle { get; set; }
        public virtual ICollection<TbMensagemProdutoFamilia> TbMensagemProdutoFamilia { get; set; }
        public virtual ICollection<TbMensagemProdutoTipo> TbMensagemProdutoTipo { get; set; }
    }
}
