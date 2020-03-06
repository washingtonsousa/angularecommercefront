using Core.Domain.Repository.Interfaces.Concrete;
using Core.Domain.EF.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Data.Repository
{
  public class PedidoRepository : IPedidoRepository
  {
    public Task Add(Pedido item)
    {
      throw new NotImplementedException();
    }

    public Task Add(IList<Pedido> item)
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

    public void Remove(Pedido item)
    {
      throw new NotImplementedException();
    }

    public void Remove(IList<Pedido> item)
    {
      throw new NotImplementedException();
    }

    public void Update(Pedido item)
    {
      throw new NotImplementedException();
    }

    public void Update(IList<Pedido> item)
    {
      throw new NotImplementedException();
    }
  }
}
