﻿using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Conteudo
    {
        public Conteudo()
        {
            ConteudoConteudoLocal = new HashSet<ConteudoConteudoLocal>();
            ConteudoSeo = new HashSet<ConteudoSeo>();
        }

        public int IdConteudo { get; set; }
        public int IdConteudoCategoria { get; set; }
        public int IdConteudoTipo { get; set; }
        public int IdConteudoTarget { get; set; }
        public bool FlStatus { get; set; }
        public bool? FlExibeCentralAtendimento { get; set; }
        public byte NuOrdem { get; set; }
        public DateTime DtCadastro { get; set; }
        public string NmConteudo { get; set; }
        public string DsUrlConteudo { get; set; }
        public string TxConteudoHtml { get; set; }
        public int? IdConteudoLocal { get; set; }
        public int? NuAlturaPopup { get; set; }
        public int? NuLarguraPopup { get; set; }
        public string DsImagem { get; set; }

        public virtual ConteudoCategoria IdConteudoCategoriaNavigation { get; set; }
        public virtual ConteudoTarget IdConteudoTargetNavigation { get; set; }
        public virtual ConteudoTipo IdConteudoTipoNavigation { get; set; }
        public virtual ICollection<ConteudoConteudoLocal> ConteudoConteudoLocal { get; set; }
        public virtual ICollection<ConteudoSeo> ConteudoSeo { get; set; }
    }
}
