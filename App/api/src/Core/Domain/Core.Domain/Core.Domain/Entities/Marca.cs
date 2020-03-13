using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Marca
    {
        public Marca()
        {
            LojaEspecialMarca = new HashSet<LojaEspecialMarca>();
            MensagemMarca = new HashSet<MensagemMarca>();
            Produto = new HashSet<Produto>();
            PromocaoMarca = new HashSet<PromocaoMarca>();
        }

        public int IdMarca { get; set; }
        public bool FlStatus { get; set; }
        public string CdExterno { get; set; }
        public DateTime DtCadastro { get; set; }
        public string NmMarca { get; set; }
        public string DsImagem { get; set; }
        public bool? FlExibeImagem { get; set; }
        public int? IdMarcaVannon { get; set; }

        public virtual ICollection<LojaEspecialMarca> LojaEspecialMarca { get; set; }
        public virtual ICollection<MensagemMarca> MensagemMarca { get; set; }
        public virtual ICollection<Produto> Produto { get; set; }
        public virtual ICollection<PromocaoMarca> PromocaoMarca { get; set; }
    }
}
