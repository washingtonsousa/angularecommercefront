using Core.BaseWeb.Controllers.Abstractions;
using Core.Shared.Kernel.Events;
using Core.Shared.Kernel.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Extensions.Modules.Marletplace.Controllers
{
  public class MarketplaceProdutoController : BaseController
  {
    public MarketplaceProdutoController(IDomainNotificationHandler<DomainNotification> domainNotification) : base(domainNotification)
    {
    }


    [HttpGet]
    public IActionResult GetProdutos()
    {

      return Ok();

    }


  }
}
