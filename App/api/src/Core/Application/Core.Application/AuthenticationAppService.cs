using AutoMapper;
using Core.Application.Abstractions;
using Core.Application.Interfaces;
using Core.BaseWeb.ViewModel;
using Core.Domain.EF.Entities;
using Core.Domain.Repository.Interfaces;
using Core.Shared.Data.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Interfaces;
using Core.Domain.Interfaces.Concrete.Services;
using Core.Domain.ActionHooks;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Application
{
  public class AuthenticationAppService : ApplicationService, IAuthenticationService
  {
    private readonly ITokenService _tokenService;
    private readonly AppSettings _appSettings;
    IClienteService _clienteService;

    public AuthenticationAppService(IOptions<AppSettings> appSettings,
    IClienteService clienteService,
    IMapper mapper,
    ITokenService tokenService,
    IUnityOfWork unityOfWork,
    IApplicationContextManager applicationContextManager,
    IServiceProvider serviceProvider)
    : base(mapper, unityOfWork,  applicationContextManager, serviceProvider)
    {

      _tokenService = tokenService;
      _appSettings = appSettings.Value;
      _clienteService = clienteService;
    }

    public async Task<ClienteViewModel> AuthenticateCliente(string userName, string password)
    {
  
      Cliente clienteFromDomain = await _clienteService.Authenticate(userName, password);

      ///Valida se autenticação funcionou e gera notificação
      if(clienteFromDomain == null)
      return null;

      ClienteViewModel cliente = _mapper.Map<ClienteViewModel>(clienteFromDomain);

      cliente.Token = _tokenService.GerarTokenCliente(clienteFromDomain);

      foreach (var service in _serviceProvider.GetServices<IClienteAoLogar>())
      {
        service.hookClienteAoLogar(clienteFromDomain);
      }

      return cliente.GetWithoutPassWord;
    }
  }
}
