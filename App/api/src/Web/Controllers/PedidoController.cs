using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    public class PedidoController : Controller
    {


        [AllowAnonymous]
        [HttpPost]
        public IActionResult AdicionarProduto()
        {
            return View();
        }

  }
}
