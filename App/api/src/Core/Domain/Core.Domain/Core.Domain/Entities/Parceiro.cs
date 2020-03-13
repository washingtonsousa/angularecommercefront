using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class Parceiro
    {
        public Parceiro()
        {
            ParceiroXmlProduto = new HashSet<ParceiroXmlProduto>();
        }

        public int IdParceiro { get; set; }
        public bool FlComparador { get; set; }
        public string CdExterno { get; set; }
        public DateTime DtCadastro { get; set; }
        public string NmParceiro { get; set; }
        public string DsLogo { get; set; }
        public string DsLink { get; set; }
        public int? NuQtdeProdutoSku { get; set; }
        public DateTime? DtGeracaoArquivo { get; set; }
        public string DsParceiro { get; set; }

        public virtual ICollection<ParceiroXmlProduto> ParceiroXmlProduto { get; set; }
    }
}
