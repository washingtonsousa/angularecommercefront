using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Etiqueta
    {
        public Etiqueta()
        {
            ProdutoEtiqueta = new HashSet<ProdutoEtiqueta>();
            Promocao = new HashSet<Promocao>();
        }

        public int IdEtiqueta { get; set; }
        public int IdEtiquetaTipo { get; set; }
        public bool FlStatus { get; set; }
        public DateTime DtCadastro { get; set; }
        public string NmEtiqueta { get; set; }
        public string DsImagem { get; set; }

        public virtual EtiquetaTipo IdEtiquetaTipoNavigation { get; set; }
        public virtual ICollection<ProdutoEtiqueta> ProdutoEtiqueta { get; set; }
        public virtual ICollection<Promocao> Promocao { get; set; }
    }
}
