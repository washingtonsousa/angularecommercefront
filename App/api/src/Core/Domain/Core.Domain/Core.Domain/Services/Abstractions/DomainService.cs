using Core.Shared.Kernel.Interfaces;

namespace Core.Domain.Services.Abstractions
{
  public abstract class DomainService
  {
    protected IDomainEventContainer _domainServiceContainerManager;

    public DomainService()
    {}

    public DomainService(IDomainEventContainer domainServiceContainerManager)
    {
      _domainServiceContainerManager = domainServiceContainerManager;
    }

  }
}
