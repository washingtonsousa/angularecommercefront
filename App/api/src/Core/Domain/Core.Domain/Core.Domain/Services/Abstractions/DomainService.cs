using Core.Shared.Kernel.Events;
using Core.Shared.Kernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Services.Abstractions
{
  public abstract class DomainService
  {
    protected IAssertionConcern _assertionConcern;
    protected IDomainServiceContainerManager _domainServiceContainerManager;

    public DomainService()
    {}

    public DomainService(IAssertionConcern assertionConcern, IDomainServiceContainerManager domainServiceContainerManager)
    {
      _assertionConcern = assertionConcern;
      _domainServiceContainerManager = domainServiceContainerManager;
    }

  }
}
