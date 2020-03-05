using Core.Domain.EF.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Interfaces.Concrete.Services
{
  public interface IClienteService
  {

    Task<bool> VerifyIfAlreadyExists(string UserName);


  }
}
