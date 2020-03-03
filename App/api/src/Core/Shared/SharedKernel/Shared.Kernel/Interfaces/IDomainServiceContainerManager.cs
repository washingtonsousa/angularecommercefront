using System;

namespace Core.Shared.Kernel.Interfaces
{
  public interface IDomainServiceContainerManager
  {
    void Raise<T>(T args) where T : IDomainEvent;

    void Notify<T>(T args) where T : IDomainEvent;

  }
}
