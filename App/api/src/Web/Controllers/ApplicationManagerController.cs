using Core.Application.Interfaces;
using Core.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiWeb.Controllers
{
  public class ApplicationManagerController : Controller
  {

    private readonly IApplicationContextManager _applicationContextManager;

    public ApplicationManagerController(IApplicationContextManager applicationContextManager)
    {
      _applicationContextManager = applicationContextManager;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var context = await _applicationContextManager.getContext();
      return Ok(context.LojaInContext);
    }
  }
}
