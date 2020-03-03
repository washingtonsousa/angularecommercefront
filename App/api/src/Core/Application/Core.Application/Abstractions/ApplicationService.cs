using AutoMapper;
using Core.Domain.Repository.Interfaces;

namespace Core.Application.Abstractions
{
  public abstract class ApplicationService
  {

    protected IMapper _mapper;
    protected IUnityOfWork _unityOfWork;

    public ApplicationService(IMapper mapper, IUnityOfWork unityOfWork)
    {
      _mapper = mapper;
      _unityOfWork = unityOfWork;

    }


  }
}
