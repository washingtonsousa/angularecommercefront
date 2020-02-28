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

        public IMapper _mapper;
        public IDepartamentoAppService _departamentoService { get; }

        public DepartamentoController(IMapper mapper, IDepartamentoAppService departamentoService)
        {
          _mapper = mapper;
          _departamentoService = departamentoService;
        }

        [HttpGet]  
        public async Task<IActionResult> GetMenuDepartamentos()
        {

              IList<DepartamentoViewModel> departamentos = _mapper.Map<IList<DepartamentoViewModel>>(await _departamentoService.ObterMenuPrincipalDepartamentos());
              return Ok(departamentos); 

           
        }
    }
}
