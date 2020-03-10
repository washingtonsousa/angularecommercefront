using Core.Application.Interfaces;
using Core.BaseWeb.Controllers.Abstractions;
using Core.BaseWeb.ViewModel;
using Core.Shared.Kernel.Events;
using Core.Shared.Kernel.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiWeb.Controllers
{
    public class LoginController : BaseController
  {
    private readonly IAuthenticationService _authenticationService;
    private readonly IClienteAppService _clienteAppService;

    public LoginController(IAuthenticationService authenticationService,
      IDomainNotificationHandler<DomainNotification> domainNotificationHandler,
      IClienteAppService clienteAppService) : base(domainNotificationHandler)
    {
      _authenticationService = authenticationService;
      _clienteAppService = clienteAppService;
    }

    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> Auth([FromBody] AuthenticateViewModel model)
    {
      if (model == null)
        return Forbid();

      var cliente = await _authenticationService.Authenticate(model.UserName, model.Password);
      return ResponseWithAllNotifications(cliente, "Autenticado com sucesso!");

    }

    /// <summary>
    /// Cadastro do cliente na plataforma
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> Subscribe([FromBody] ClienteViewModel model)
    {

     await _clienteAppService.SubscribeCliente(model);
     return ResponseWithAllNotifications(model, "Cadastrado com sucesso!");

    }

    /// <summary>
    /// Atualização do cliente na plataforma
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    [HttpPut]
    public async Task<IActionResult> Update([FromBody] ClienteViewModel model)
    {

      await _clienteAppService.UpdateCliente(model);
      return ResponseWithAllNotifications(model, "Atualizado com sucesso!");

    }

  }
}
