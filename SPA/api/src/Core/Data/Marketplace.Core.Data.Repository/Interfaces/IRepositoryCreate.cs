using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marketplace.Core.Domain.Repository.Interfaces
{
  public interface IRepositoryCreate<T> where T : new()
  {

    void Add(T item);

    void Add(IList<T> item);

  }
}
