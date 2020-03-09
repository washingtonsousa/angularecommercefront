using AutoMapper;
using Core.Application.Abstractions;
using Core.Application.Interfaces;
using Core.BaseWeb.ViewModel;
using Core.Domain.EF.Entities;
using Core.Domain.Interfaces;
using Core.Domain.Interfaces.ActionHooks;
using Core.Domain.Interfaces.Concrete.Services;
using Core.Domain.Repository.Interfaces;
using Core.Domain.Repository.Interfaces.Concrete;
using Core.Domain.Specification;
using Core.Shared.Kernel.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;


namespace Core.Application
{
  public class ClienteAppService: ApplicationService, IClienteAppService
  {
    IClienteService _clienteService;
    IClienteRepository _clienteRepository;

    public ClienteAppService(IMapper mapper,
      IClienteRepository clienteRepository,
      IUnityOfWork unityOfWork,
      IApplicationContextManager applicationContextManager,
      IClienteService clienteService,
      IServiceProvider serviceProvider) : base( mapper, unityOfWork, applicationContextManager, serviceProvider) 
    {
      _clienteService = clienteService;
      _clienteRepository = clienteRepository;
    }

    public async Task SubscribeCliente(ClienteViewModel cliente)
    {
      Cliente clienteDomain = _mapper.Map<Cliente>(cliente);

      if (!((clienteDomain.FlTipoPessoa != "J") ? clienteDomain.ValidateForSubscription() : clienteDomain.ValidateEnterpriseForSubscription()))
        return;

      if (await _clienteService.CheckIfExists(clienteDomain.DsEmail, clienteDomain.DsCpfCnpj))
        return;

      await _clienteRepository.Add(_mapper.Map<Cliente>(cliente));

      await _unityOfWork.CommitAsync();

      var services =  _serviceProvider.GetServices<IClienteAoCadastrar>();

      foreach (var service in services)
      {
        service.hookAoCadastrarExecute(clienteDomain);
      }

    }

    public async Task UpdateCliente(ClienteViewModel cliente)
    {
      Cliente clienteForUpdate = await _clienteService.CheckIfNotExists(cliente.DsEmail, cliente.DsCpfCnpj);
      Cliente clienteFromModel = _mapper.Map<Cliente>(cliente);

      if (clienteForUpdate == null)
        return;

      if (!((clienteForUpdate.FlTipoPessoa != "J") ? clienteFromModel.ValidateForSubscription() : clienteFromModel.ValidateEnterpriseForSubscription()))
        return;

      _clienteService.UpdateCliente(clienteForUpdate, _mapper.Map<Cliente>(cliente));

      await _unityOfWork.CommitAsync();

    }
  }
}
