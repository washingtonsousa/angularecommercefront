using Core.Application.Interfaces;
using Core.BaseWeb.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiWeb.Controllers
{
    public class LoginController : Controller
    {
    private readonly IAuthenticationService _authenticationService;

    public LoginController(IAuthenticationService authenticationService)
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

      if (cliente == null)
        return BadRequest(new { message = "Usuário ou senha incorreta" });

      return Ok(cliente);
    }

  }
}
