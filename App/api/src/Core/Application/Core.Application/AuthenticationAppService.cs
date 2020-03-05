using AutoMapper;
using Core.Application.Abstractions;
using Core.Application.Interfaces;
using Core.BaseWeb.ViewModel;
using Core.Domain.Repository.Interfaces.Concrete;
using Core.Domain.EF.Entities;
using Core.Domain.Repository.Interfaces;
using Core.Shared.Data.Models;
using Core.Shared.Kernel.Interfaces;
using Encryption;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Interfaces;

namespace Core.Application
{
  public class AuthenticationAppService : ApplicationService, IAuthenticationService
  {
    private readonly AppSettings _appSettings;
    private IClienteRepository _clienteRepository;

    public AuthenticationAppService(IOptions<AppSettings> appSettings,
    IClienteRepository clienteRepository,
    IMapper mapper,
    IUnityOfWork unityOfWork,
    IApplicationContextManager applicationContextManager,
    IAssertionConcern assertionConcern)
    : base(mapper, unityOfWork, assertionConcern, applicationContextManager)
    {
      _appSettings = appSettings.Value;
      _clienteRepository = clienteRepository;
    }

    public async Task<ClienteViewModel> Authenticate(string userName, string password)
    {
  
      Cliente clienteFromDomain =  await _clienteRepository.GetForAuthentication(userName, Crypto.ActionEncrypt(password));

      ///Valida se autenticação funcionou e gera notificação
      if(!_assertionConcern.IsSatisfiedBy(_assertionConcern.AssertNotNull(clienteFromDomain, "Usuário ou senha inválidos")))
      return null;

      ClienteViewModel cliente = _mapper.Map<ClienteViewModel>(clienteFromDomain);

      // gera o Token JWT já que a autenticação funcionou
      var tokenHandler = new JwtSecurityTokenHandler();
      var key = Encoding.ASCII.GetBytes(_appSettings.AppSecret);
      var tokenDescriptor = new SecurityTokenDescriptor
      {
        Subject = new ClaimsIdentity(new Claim[]
          {
                    new Claim(ClaimTypes.NameIdentifier, cliente.IdCliente.ToString()),
                    new Claim(ClaimTypes.Name, cliente.NmCliente),
                    new Claim(ClaimTypes.Email, cliente.DsEmail)
          }),
        Expires = DateTime.UtcNow.AddDays(1),
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
      };
      var token = tokenHandler.CreateToken(tokenDescriptor);
      cliente.Token = tokenHandler.WriteToken(token);

      return cliente.GetWithoutPassWord;
    }
  }
}
