using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
