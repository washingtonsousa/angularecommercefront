using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Data.Repository;
using Core.Domain.Interfaces.Concrete.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MarketplaceWeb.Controllers
{
    public class ProdutoController : Controller
    {

      public ProdutoController()
      {

      }

      public IActionResult Index()
      {
        return Ok();
      }


   }
}
