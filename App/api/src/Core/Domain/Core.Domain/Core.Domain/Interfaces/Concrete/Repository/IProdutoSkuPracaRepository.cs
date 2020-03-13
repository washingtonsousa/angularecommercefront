using Core.Domain.EF.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Interfaces.Concrete.Repository
{
  public interface IProdutoSkuPracaRepository
  {
    Task<IList<ProdutoSkuPraca>> SearchProdutosSkuPracaByPracaId(int IdPraca, int? departamentoId, int? sessaoId, int? page, int take = 60);


    Task<IList<ProdutoSkuPraca>> SearchProdutosSkuPracaOrderedByPrice(int? departamentoId, int? sessaoId, int? page, int take = 60);

  }
}
