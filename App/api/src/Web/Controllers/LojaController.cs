using System;
using Core.BaseWeb.Controllers.Abstractions;
using Core.Shared.Kernel.Events;
using Core.Shared.Kernel.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    public class LojaController : BaseController
  {
    public LojaController(IDomainNotificationHandler<DomainNotification> domainNotification) : base(domainNotification)
    {
    }

    public IActionResult Index()
        {
            return View();
        }
    }
}
