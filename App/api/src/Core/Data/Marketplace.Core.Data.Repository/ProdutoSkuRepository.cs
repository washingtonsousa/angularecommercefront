using Marketplace.Core.Data.Repository.Interfaces.Concrete;
using Marketplace.Core.Domain.EF.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Core.Data.Repository
{
  public class ProdutoSkuRepository : IProdutoSkuRepository
  {
    public Task<ProdutoSku> Get(int Id)
    {
      throw new NotImplementedException();
    }

    public Task<IList<ProdutoSku>> Get()
    {
      throw new NotImplementedException();
    }
  }
}
