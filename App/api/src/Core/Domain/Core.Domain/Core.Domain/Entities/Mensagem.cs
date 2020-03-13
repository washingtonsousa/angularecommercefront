using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Mensagem
    {
        public Mensagem()
        {
            MensagemCategoria = new HashSet<MensagemCategoria>();
            MensagemMarca = new HashSet<MensagemMarca>();
            MensagemPrincipioAtivo = new HashSet<MensagemPrincipioAtivo>();
            MensagemProdutoControle = new HashSet<MensagemProdutoControle>();
            MensagemProdutoFamilia = new HashSet<MensagemProdutoFamilia>();
            MensagemProdutoTipo = new HashSet<MensagemProdutoTipo>();
        }

        public int IdMensagem { get; set; }
        public string CdExterno { get; set; }
        public bool FlStatus { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
        public string DsMensagem { get; set; }
        public string DsTitulo { get; set; }

        public virtual ICollection<MensagemCategoria> MensagemCategoria { get; set; }
        public virtual ICollection<MensagemMarca> MensagemMarca { get; set; }
        public virtual ICollection<MensagemPrincipioAtivo> MensagemPrincipioAtivo { get; set; }
        public virtual ICollection<MensagemProdutoControle> MensagemProdutoControle { get; set; }
        public virtual ICollection<MensagemProdutoFamilia> MensagemProdutoFamilia { get; set; }
        public virtual ICollection<MensagemProdutoTipo> MensagemProdutoTipo { get; set; }
    }
}
