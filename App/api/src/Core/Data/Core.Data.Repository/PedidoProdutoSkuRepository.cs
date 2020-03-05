using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Data.EF.Context;
using Core.Domain.Repository.Interfaces.Concrete;
using Core.Domain.EF.Entities;
using Core.Domain.Repository.Abstractions;

namespace Core.Data.Repository
{
  public class PedidoProdutoSkuRepository : RepositoryTemplate, IPedidoProdutoSkuRepository
  {
    public PedidoProdutoSkuRepository(MainContext context) : base(context)
    {
    }

    public void Add(PedidoProdutoSku item)
    {
      throw new System.NotImplementedException();
    }

    public void Add(IList<PedidoProdutoSku> item)
    {
      throw new System.NotImplementedException();
    }

    public Task<PedidoProdutoSku> Get(int Id)
    {
      throw new System.NotImplementedException();
    }

    public Task<IList<PedidoProdutoSku>> Get()
    {
      throw new System.NotImplementedException();
    }

    public Task<PedidoProdutoSku> GetFirstRecord()
    {
      throw new System.NotImplementedException();
    }

    public Task Remove(PedidoProdutoSku item)
    {
      throw new System.NotImplementedException();
    }

    public Task Remove(IList<PedidoProdutoSku> item)
    {
      throw new System.NotImplementedException();
    }

    public Task Update(PedidoProdutoSku item)
    {
      throw new System.NotImplementedException();
    }

    public Task Update(IList<PedidoProdutoSku> item)
    {
      throw new System.NotImplementedException();
    }
  }
}
