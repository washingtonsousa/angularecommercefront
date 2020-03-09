using AutoMapper;
using Core.Application.Interfaces;
using Core.Domain.Interfaces;
using Core.Domain.Repository.Interfaces;
using Core.Shared.Kernel.Interfaces;
using System;

namespace Core.Application.Abstractions
{
  public abstract class ApplicationService
  {

    protected IMapper _mapper;
    protected IUnityOfWork _unityOfWork;
    protected IApplicationContextManager _applicationContextManager;
    protected IServiceProvider _serviceProvider;


    public ApplicationService(IMapper mapper, IUnityOfWork unityOfWork, IApplicationContextManager applicationContextManager, IServiceProvider serviceProvider)
    {
      _mapper = mapper;
      _unityOfWork = unityOfWork;
      _applicationContextManager = applicationContextManager;
      _serviceProvider = serviceProvider;
    }

    public ApplicationService(IMapper mapper, IUnityOfWork unityOfWork, IApplicationContextManager applicationContextManager)
    {
      _mapper = mapper;
      _unityOfWork = unityOfWork;
      _applicationContextManager= applicationContextManager;
    }

    public ApplicationService(IMapper mapper, IApplicationContextManager applicationContextManager)
    {
      _mapper = mapper;
      _applicationContextManager = applicationContextManager;
    }

    public ApplicationService()
    {
    }
  }
}
