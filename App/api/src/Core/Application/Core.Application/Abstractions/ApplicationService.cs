using AutoMapper;
using Core.Domain.Repository.Interfaces;
using Core.Shared.Kernel.Events;
using Core.Shared.Kernel.Interfaces;

namespace Core.Application.Abstractions
{
  public abstract class ApplicationService
  {

    protected IMapper _mapper;
    protected IUnityOfWork _unityOfWork;
    protected IAssertionConcern _assertionConcern;
    public ApplicationService(IMapper mapper, IUnityOfWork unityOfWork, IAssertionConcern assertionConcern)
    {
      _mapper = mapper;
      _unityOfWork = unityOfWork;
      _assertionConcern = assertionConcern;
    }

    public ApplicationService(IMapper mapper, IUnityOfWork unityOfWork)
    {
      _mapper = mapper;
    }

    public ApplicationService(IMapper mapper)
    {
      _mapper = mapper;
    }

    public ApplicationService()
    {
    }
  }
}
