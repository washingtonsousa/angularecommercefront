using AutoMapper;
using Core.Application.Abstractions;
using Core.Application.Interfaces;
using Core.Domain.EF.Entities;
using Core.Domain.Interfaces;
using Core.Domain.Repository.Interfaces;
using Core.Shared.Data.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Core.Application
{
  public class TokenService : ApplicationService , ITokenService
  {

    private readonly JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
    private readonly AppSettings _appSettings;

    public TokenService(IMapper mapper,
      IUnityOfWork unityOfWork,
      IOptions<AppSettings> appSettings,
      IApplicationContextManager applicationContextManager,
      IServiceProvider serviceProvider) : base(mapper, unityOfWork, applicationContextManager, serviceProvider)
    {
      _appSettings = appSettings.Value;
    }

    public string GerarTokenCliente(Cliente cliente)
    {
      var key = Encoding.ASCII.GetBytes(_appSettings.AppSecret);
      var tokenDescriptor = new SecurityTokenDescriptor
      {
        Subject = new ClaimsIdentity(new Claim[]
          {
                    new Claim(ClaimTypes.NameIdentifier, cliente.IdCliente.ToString()),
                    new Claim("Id", cliente.IdCliente.ToString()),
                    new Claim(ClaimTypes.Name, cliente.NmCliente),
                    new Claim(ClaimTypes.Email, cliente.DsEmail),
                    new Claim(ClaimTypes.Role, "Cliente")
          }),
        Expires = DateTime.UtcNow.AddDays(1),
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
      };

      var token = tokenHandler.CreateToken(tokenDescriptor);

      return tokenHandler.WriteToken(token);
    }


  }
}
