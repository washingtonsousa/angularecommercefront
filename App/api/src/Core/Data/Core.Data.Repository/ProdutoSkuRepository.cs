using Core.Domain.Repository.Interfaces.Concrete;
using Core.Domain.EF.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Domain.Repository
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

    public Task<ProdutoSku> GetFirstRecord()
    {
      throw new NotImplementedException();
    }
  }
}
