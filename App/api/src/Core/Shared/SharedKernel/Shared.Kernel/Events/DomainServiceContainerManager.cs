using Core.Shared.Kernel.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Core.Shared.Kernel.Events
{
  public class DomainServiceContainerManager : IDomainServiceContainerManager
  {
    private readonly IServiceProvider _serviceProvider;

    public DomainServiceContainerManager(IServiceProvider serviceProvider)
    {
      _serviceProvider = serviceProvider;
    }

    public void Raise<T>(T args) where T : IDomainEvent
    {
      if (_serviceProvider != null)
      {
        foreach (var handler in _serviceProvider.GetServices<IHandler<T>>())
          ((IHandler<T>)handler).Handle(args);
      }
    }

    public void Notify<T>(T args) where T : IDomainEvent
    {
      if (_serviceProvider != null)
      {
        foreach (var handler in _serviceProvider.GetServices<IDomainNotificationHandler<T>>())
          handler.Handle(args);
      }
    }


    public void DomainNotify(DomainNotification args)
    {
      if (_serviceProvider != null)
      {
        foreach (var handler in _serviceProvider.GetServices<IDomainNotificationHandler<DomainNotification>>())
          handler.Handle(args);
      }
    }
  }
}
