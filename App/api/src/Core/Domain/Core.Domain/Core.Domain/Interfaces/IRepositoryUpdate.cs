
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Domain.Repository.Interfaces
{
  public interface IRepositoryUpdate<T> where T : new()
  {

    Task Update(T item);

    Task Update(IList<T> item);

  }
}
