using Core.Shared.Kernel.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Shared.Kernel.Events
{
  public class DomainServiceContainerManager : IDomainServiceContainerManager
  {
    private readonly IServiceCollection _serviceProvider;

    public DomainServiceContainerManager(IServiceCollection serviceProvider)
    {
      _serviceProvider = serviceProvider;
    }

    public void Raise<T>(T args) where T : IDomainEvent
    {
      if (_serviceProvider != null)
      {
        foreach (var handler in _serviceProvider.BuildServiceProvider().GetServices<IHandler<T>>())
          ((IHandler<T>)handler).Handle(args);
      }
    }

    public void Notify<T>(T args) where T : IDomainEvent
    {
      if (_serviceProvider != null)
      {
        foreach (var handler in _serviceProvider.BuildServiceProvider().GetServices<IHandler<T>>())
          ((IDomainNotificationHandler<T>)handler).Handle(args);
      }
    }
  }
}
