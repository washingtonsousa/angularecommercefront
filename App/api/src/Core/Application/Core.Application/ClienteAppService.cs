using AutoMapper;
using Core.Application.Abstractions;
using Core.Application.Interfaces;
using Core.BaseWeb.ViewModel;
using Core.Domain.EF.Entities;
using Core.Domain.Interfaces;
using Core.Domain.Repository.Interfaces;

namespace Core.Application
{
  public class ClienteAppService: ApplicationService, IClienteAppService
  {

    public ClienteAppService(IMapper mapper, IUnityOfWork unityOfWork, IApplicationContextManager applicationContextManager): base( mapper, unityOfWork, applicationContextManager) 
    {

    }


    public void SubscribeCliente(ClienteViewModel cliente)
    {



    }




  }
}
