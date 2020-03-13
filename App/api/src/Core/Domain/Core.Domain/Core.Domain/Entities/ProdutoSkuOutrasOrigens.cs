using System;
using System.Collections.Generic;

namespace Core.Domain.EF.Entities
{
    public partial class ProdutoSkuOutrasOrigens
    {
        public int IdProdutoSku { get; set; }
        public int IdProduto { get; set; }
        public bool FlBrinde { get; set; }
        public string CdExterno { get; set; }
        public string CdBarras { get; set; }
        public decimal NuPeso { get; set; }
        public int NuAltura { get; set; }
        public int NuLargura { get; set; }
        public int NuProfundidade { get; set; }
        public string NmProdutoSku { get; set; }
        public string CdMs { get; set; }
        public decimal? PcDescontoAtendente { get; set; }
        public DateTime? DtCadastro { get; set; }
        public bool FlExibirIndividualmente { get; set; }
        public string Origem { get; set; }
    }
}
