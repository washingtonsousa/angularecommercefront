using Core.BaseWeb.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Interfaces
{
  public interface IAuthenticationService
  {
    Task<ClienteViewModel> AuthenticateCliente(string userName, string password);
  }
}
