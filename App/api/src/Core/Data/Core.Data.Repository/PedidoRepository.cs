using Core.Data.Repository.Interfaces.Concrete;
using Core.Domain.EF.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Data.Repository
{
  public class PedidoRepository : IPedidoRepository
  {
    public void Add(Pedido item)
    {
      throw new NotImplementedException();
    }

    public void Add(IList<Pedido> item)
    {
      throw new NotImplementedException();
    }

    public Task<Pedido> Get(int Id)
    {
      throw new NotImplementedException();
    }

    public Task<IList<Pedido>> Get()
    {
      throw new NotImplementedException();
    }

    public Task<Pedido> GetFirstRecord()
    {
      throw new NotImplementedException();
    }

    public Task Remove(Pedido item)
    {
      throw new NotImplementedException();
    }

    public Task Remove(IList<Pedido> item)
    {
      throw new NotImplementedException();
    }

    public Task Update(Pedido item)
    {
      throw new NotImplementedException();
    }

    public Task Update(IList<Pedido> item)
    {
      throw new NotImplementedException();
    }
  }
}
