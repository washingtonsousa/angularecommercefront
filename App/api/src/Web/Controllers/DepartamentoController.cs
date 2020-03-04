using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Application.Interfaces;
using Core.BaseWeb.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MarketplaceWeb.Controllers
{
 
    public class DepartamentoController : Controller
    {
        public IDepartamentoAppService _departamentoService { get; }
        private readonly IApplicationContextManager _applicationContextManager;

        public DepartamentoController(IDepartamentoAppService departamentoService, IApplicationContextManager applicationContextManager)
        {
          _departamentoService = departamentoService;
          _applicationContextManager = applicationContextManager;
        }


        [HttpGet]  
        public async Task<IActionResult> GetMenuDepartamentos()
        {

              var context = await _applicationContextManager.getContext();

              IList<DepartamentoViewModel> departamentos = await _departamentoService.ObterMenuPrincipalDepartamentos();
              return Ok(departamentos); 

        }
    }
}
