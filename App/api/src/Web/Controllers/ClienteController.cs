using Core.BaseWeb.Controllers.Abstractions;
using Core.Shared.Kernel.Events;
using Core.Shared.Kernel.Interfaces;

namespace ApiWeb.Controllers
{
  public class ClienteController : BaseController
  {
    public ClienteController(IDomainNotificationHandler<DomainNotification> domainNotification) : base(domainNotification)
    {
    }




  }
}
