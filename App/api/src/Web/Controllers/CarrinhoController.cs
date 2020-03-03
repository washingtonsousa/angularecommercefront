using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
