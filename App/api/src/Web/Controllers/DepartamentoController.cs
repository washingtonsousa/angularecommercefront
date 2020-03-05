using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Application.Interfaces;
using Core.BaseWeb.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace MarketplaceWeb.Controllers
{
 
    public class DepartamentoController : Controller
    {
        public IDepartamentoAppService _departamentoService { get; }


        public DepartamentoController(IDepartamentoAppService departamentoService)
        {
          _departamentoService = departamentoService;
        }


        [HttpGet]  
        public async Task<IActionResult> GetMenuDepartamentos()
        {


              IList<DepartamentoViewModel> departamentos = await _departamentoService.ObterMenuPrincipalDepartamentos();
              return Ok(departamentos); 

        }
    }
}
