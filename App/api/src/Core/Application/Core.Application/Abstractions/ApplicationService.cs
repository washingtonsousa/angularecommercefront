using AutoMapper;
using Core.Application.Interfaces;
using Core.Domain.Interfaces;
using Core.Domain.Repository.Interfaces;
using Core.Shared.Kernel.Interfaces;

namespace Core.Application.Abstractions
{
  public abstract class ApplicationService
  {

    protected IMapper _mapper;
    protected IUnityOfWork _unityOfWork;
    protected IAssertionConcern _assertionConcern;
    protected IApplicationContextManager _applicationContextManager;

    public ApplicationService(IMapper mapper, IUnityOfWork unityOfWork, IAssertionConcern assertionConcern, IApplicationContextManager applicationContextManager)
    {
      _mapper = mapper;
      _unityOfWork = unityOfWork;
      _assertionConcern = assertionConcern;
      _applicationContextManager= applicationContextManager;
    }

    public ApplicationService(IMapper mapper, IUnityOfWork unityOfWork, IApplicationContextManager applicationContextManager)
    {
      _mapper = mapper;
      _unityOfWork = unityOfWork;
      _applicationContextManager = applicationContextManager;
    }

    public ApplicationService(IMapper mapper, IApplicationContextManager applicationContextManager)
    {
      _mapper = mapper;
      _applicationContextManager = applicationContextManager;
    }


    public ApplicationService(IApplicationContextManager applicationContextManager)
    {
      _applicationContextManager = applicationContextManager;
    }

    public ApplicationService()
    {
    }
  }
}
