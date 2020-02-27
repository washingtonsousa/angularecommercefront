using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marketplace.Core.Domain.Repository.Interfaces
{
  public interface IUnityOfWork
  {

    void Commit();
    Task CommitAsync();

  }
}
