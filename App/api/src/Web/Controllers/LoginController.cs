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

    public LoginController(IAuthenticationService authenticationService,
      IDomainNotificationHandler<DomainNotification> domainNotificationHandler) : base(domainNotificationHandler)
    {
      _authenticationService = authenticationService;
    }

    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> Auth([FromBody] AuthenticateViewModel model)
    {
      if (model == null)
        return Forbid();

      var cliente = await _authenticationService.Authenticate(model.UserName, model.Password);
      return ResponseWithFirstNotification(cliente, "Autenticado com sucesso!");

    }


    [HttpPost]
    public async Task<IActionResult> Subscribe([FromBody] ClienteViewModel model)
    {



   
      return ResponseWithFirstNotification(model, "Cadastrado com sucesso!");

    }

  }
}
