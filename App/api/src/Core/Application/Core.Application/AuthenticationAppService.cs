using AutoMapper;
using Core.Application.Abstractions;
using Core.Application.Interfaces;
using Core.BaseWeb.ViewModel;
using Core.Data.Repository.Interfaces.Concrete;
using Core.Domain.Repository.Interfaces;
using Core.Shared.Data.Models;
using Encryption;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application
{
  public class AuthenticationAppService : ApplicationService, IAuthenticationService
  {
    private readonly AppSettings _appSettings;
    private IClienteRepository _clienteRepository;

    public AuthenticationAppService(IOptions<AppSettings> appSettings, IClienteRepository clienteRepository, IMapper mapper, IUnityOfWork unityOfWork) : base(mapper, unityOfWork)
    {
      _appSettings = appSettings.Value;
      _clienteRepository = clienteRepository;
    }

    public async Task<ClienteViewModel> Authenticate(string userName, string password)
    {
  
      ClienteViewModel cliente =  _mapper.Map<ClienteViewModel>(await _clienteRepository.GetForAuthentication(userName, Crypto.ActionEncrypt(password)));

      if (cliente == null)
        return null;

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
