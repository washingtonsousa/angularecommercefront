using AutoMapper;
using Core.Application.Abstractions;
using Core.Application.Interfaces;
using Core.BaseWeb.ViewModel;
using Core.Domain.EF.Entities;
using Core.Domain.Interfaces;
using Core.Domain.Interfaces.Concrete.Services;
using Core.Domain.Interfaces.Concrete.Specification;
using Core.Domain.Repository.Interfaces;
using System.Threading.Tasks;

namespace Core.Application
{
  public class ClienteAppService: ApplicationService, IClienteAppService
  {
    IClienteService _clienteService;
    IClienteSpecification _clienteSpecification;

    public ClienteAppService(IMapper mapper,
      IUnityOfWork unityOfWork,
      IApplicationContextManager applicationContextManager,
      IClienteService clienteService,
      IClienteSpecification clienteEspecification) : base( mapper, unityOfWork, applicationContextManager) 
    {
      _clienteService = clienteService;
      _clienteSpecification = clienteEspecification;
    }

    public async Task SubscribeCliente(ClienteViewModel cliente)
    {
      Cliente clienteDomain = _mapper.Map<Cliente>(cliente);

      if (!((clienteDomain.FlTipoPessoa != "J") ? _clienteSpecification.ValidateForSubscription(clienteDomain) : _clienteSpecification.ValidateEnterpriseForSubscription(clienteDomain)))
        return;

      if (await _clienteService.CheckIfExists(clienteDomain.DsEmail, clienteDomain.DsCpfCnpj))
        return;

      _clienteService.AddCliente(_mapper.Map<Cliente>(cliente));

      await _unityOfWork.CommitAsync();
    }


    public async Task UpdateCliente(ClienteViewModel cliente)
    {
      Cliente clienteForUpdate = await _clienteService.CheckIfNotExists(cliente.DsEmail, cliente.DsCpfCnpj);

      if (clienteForUpdate == null)
        return;

      if (!((clienteForUpdate.FlTipoPessoa != "J") ? _clienteSpecification.ValidateForSubscription(clienteForUpdate) : _clienteSpecification.ValidateEnterpriseForSubscription(clienteForUpdate)))
        return;

      _clienteService.UpdateCliente(clienteForUpdate, _mapper.Map<Cliente>(cliente));

      await _unityOfWork.CommitAsync();

    }




  }
}
