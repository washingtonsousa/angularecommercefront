using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbMarca
    {
        public TbMarca()
        {
            TbLojaEspecialMarca = new HashSet<TbLojaEspecialMarca>();
            TbMensagemMarca = new HashSet<TbMensagemMarca>();
            TbProduto = new HashSet<TbProduto>();
            TbPromocaoMarca = new HashSet<TbPromocaoMarca>();
        }

        public int IdMarca { get; set; }
        public bool FlStatus { get; set; }
        public string CdExterno { get; set; }
        public DateTime DtCadastro { get; set; }
        public string NmMarca { get; set; }
        public string DsImagem { get; set; }
        public bool? FlExibeImagem { get; set; }
        public int? IdMarcaVannon { get; set; }

        public virtual ICollection<TbLojaEspecialMarca> TbLojaEspecialMarca { get; set; }
        public virtual ICollection<TbMensagemMarca> TbMensagemMarca { get; set; }
        public virtual ICollection<TbProduto> TbProduto { get; set; }
        public virtual ICollection<TbPromocaoMarca> TbPromocaoMarca { get; set; }
    }
}
