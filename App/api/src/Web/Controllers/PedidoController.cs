using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
