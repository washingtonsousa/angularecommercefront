using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marketplace.Core.Domain.Repository.Interfaces
{
  public interface IRepositoryDelete<T> where T : new()
  {

    Task Remove(T item);

    Task Remove(IList<T> item);

  }
}
