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
using System.Linq;
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

    /// <summary>
    /// Cadastra novo cliente
    /// </summary>
    /// <param name="cliente"></param>
    /// <returns></returns>
    public async Task SubscribeCliente(ClienteViewModel cliente)
    {

      Cliente clienteDomain = _mapper.Map<Cliente>(cliente).PrepareForSubscription();

      if (!((clienteDomain.FlTipoPessoa != "J") ? clienteDomain.ValidateForSubscription() : clienteDomain.ValidateEnterpriseForSubscription()))
        return;

      if (await _clienteService.CheckIfExists(clienteDomain.DsEmail, clienteDomain.DsCpfCnpj))
        return;

      await _clienteRepository.Add(clienteDomain);

      await _unityOfWork.CommitAsync();

      foreach (var service in _serviceProvider.GetServices<IClienteAoCadastrar>())
      {
        service.hookAoCadastrarExecute(clienteDomain);
      }

    }

    /// <summary>
    /// Atualiza cliente logado
    /// </summary>
    /// <param name="cliente"></param>
    /// <returns></returns>
    public async Task UpdateCliente(ClienteViewModel cliente)
    {
     

      Cliente clienteForUpdate = await _clienteService.CheckIfNotExists(cliente.IdCliente);
      Cliente clienteFromModel = _mapper.Map<Cliente>(cliente);

      if (clienteForUpdate == null)
        return;

      if (clienteFromModel.ValidateLoggedInUser(ObterIdClienteLogado()))
        return;

      //Se PJ valida dados de PJ se PF valida dados de PF
      if (!((clienteForUpdate.FlTipoPessoa != "J") ? clienteFromModel.ValidateForUpdate() : clienteFromModel.ValidateEnterpriseForUpdate()))
        return;
      //Valida se usuário logado é o que está para ser atualizado
  

      clienteForUpdate.Update(clienteFromModel);

      _clienteRepository.Update(clienteForUpdate);

      await _unityOfWork.CommitAsync();

    }

    public async Task<ClienteViewModel> ObterClienteLogado() =>  _mapper.Map<ClienteViewModel>( await ObterClienteLogadoDomain() );

    private async Task<Cliente> ObterClienteLogadoDomain() =>  await _clienteRepository.Get(ObterIdClienteLogado());

    /// <summary>
    /// Obtem Id do cliente logado no ato da request - é necessário que esteja em uma rota de contexto em que o app precisa fornecer o token
    /// </summary>
    /// <returns>Id do cliente logado</returns>
    private int ObterIdClienteLogado()
    {
      var context = _applicationContextManager.getContext().GetAwaiter().GetResult();
      var claim = context.UserInContext.Claims.Where(c => c.Type == "Id").FirstOrDefault();
      string primitiveId = (claim != null) ? claim.Value : "0";
      int.TryParse(primitiveId, out int Id);
      return Id;
    }
  }
}
