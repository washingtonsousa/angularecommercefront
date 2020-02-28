using System;
using System.Collections.Generic;

namespace Marketplace.Core.Domain.EF.Entities
{
    public partial class TbEtiqueta
    {
        public TbEtiqueta()
        {
            TbProdutoEtiqueta = new HashSet<TbProdutoEtiqueta>();
            TbPromocao = new HashSet<TbPromocao>();
        }

        public int IdEtiqueta { get; set; }
        public int IdEtiquetaTipo { get; set; }
        public bool FlStatus { get; set; }
        public DateTime DtCadastro { get; set; }
        public string NmEtiqueta { get; set; }
        public string DsImagem { get; set; }

        public virtual TbEtiquetaTipo IdEtiquetaTipoNavigation { get; set; }
        public virtual ICollection<TbProdutoEtiqueta> TbProdutoEtiqueta { get; set; }
        public virtual ICollection<TbPromocao> TbPromocao { get; set; }
    }
}
