using Core.Application.Interfaces;
using Core.BaseWeb.Controllers.Abstractions;
using Core.Shared.Data;
using Core.Shared.Kernel.Events;
using Core.Shared.Kernel.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiWeb.Controllers
{
  public class ClienteController : BaseController
  {
    public ClienteController(IDomainNotificationHandler<DomainNotification> domainNotification, IClienteAppService clienteAppService) : base(domainNotification)
    {

      _clienteAppService = clienteAppService;

    }

    public IClienteAppService _clienteAppService { get; private set; }


    /// <summary>
    /// Obter Cliente Logado
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    [HttpGet]
    [Authorize(Roles = Constants.CustomerRole)]
    public async Task<IActionResult> GetCurrent()
    {

      var cliente = await _clienteAppService.GetCurrentLoggedInCliente();

      return ResponseWithAllNotifications(cliente.GetWithoutPassWord, "Operação concluída com  sucesso!");

    }


  }
}
