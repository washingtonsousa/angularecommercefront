using AutoMapper;
using Marketplace.Core.Domain.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketplace.Core.Application.Abstractions
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
