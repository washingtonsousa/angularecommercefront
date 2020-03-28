using Core.Domain.EF.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Application.Interfaces
{
  public interface ITokenService
  {
    string GerarTokenCliente(Cliente cliente);
  }
}
