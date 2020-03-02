using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Marketplace.Core.Application.Interfaces;
using Marketplace.Core.BaseWeb.ViewModel;
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
