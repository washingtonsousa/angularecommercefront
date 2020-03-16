using Core.BaseWeb.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Interfaces
{
  public interface IClienteAppService
  {
    Task SubscribeCliente(ClienteViewModel cliente);
    Task UpdateCliente(ClienteViewModel cliente);
    Task<ClienteViewModel> GetCurrentLoggedInCliente();

  }
}
