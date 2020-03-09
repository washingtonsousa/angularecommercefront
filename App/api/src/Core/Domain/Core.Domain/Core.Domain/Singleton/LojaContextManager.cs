
using Core.Domain.Interfaces;
using Core.Domain.Repository.Interfaces.Concrete;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using Core.Domain.Interfaces.Concrete.Repository;
using Core.Domain.Entities;
using System.Collections.Generic;

namespace Core.Domain.Singleton
{
  public class ApplicationContextManager : IApplicationContextManager
  {

    private  ApplicationContext _context;
    private readonly IDadosLojaRepository _dadosLojaRepository;
    private readonly IPracaRepository _pracaRepository;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IApplicationModuleRepository _applicationModuleRepository;
    private HttpContext httpContext;

    public ApplicationContextManager(IDadosLojaRepository dadosLojaRepository,
      IPracaRepository pracaRepository,
      IHttpContextAccessor httpContextAccessor,
      IApplicationModuleRepository applicationModuleRepository)
    {
      _dadosLojaRepository = dadosLojaRepository;
      _pracaRepository = pracaRepository;
      _httpContextAccessor = httpContextAccessor;
      _applicationModuleRepository = applicationModuleRepository;

    }

    public async Task<ApplicationContext> getContext()
    {

      if (_context == null)
        _context = await buildApplicationContext();

      return _context;

    }

    private async Task<ApplicationContext> buildApplicationContext()
    {

      ApplicationContext context = new ApplicationContext();

      httpContext = _httpContextAccessor.HttpContext;

      context.LojaInContext = await _dadosLojaRepository.GetFirstRecord();
      context.UserInContext = (httpContext  != null) ? httpContext.User : null;
      context.Modules = await GetApplicationModules();
      await GetCurrentPraca(context);
      GetCurrentPedidoId(context);

      return context;

    }

    private async Task<IList<ApplicationModule>> GetApplicationModules()
    {
      return await _applicationModuleRepository.Get();
    }

    private  async Task GetCurrentPraca(ApplicationContext context)
    {
      if (httpContext != null)
      {
        httpContext.Request.Headers.TryGetValue("X-Loja-Id", out StringValues pracaFromheader);
        int pracaId = (pracaFromheader.Count <= 0) ? 0 : int.Parse(pracaFromheader.ToString());
        context.PracaAtual = await _pracaRepository.Get(pracaId);
      }
      }


    private  void GetCurrentPedidoId(ApplicationContext context)
    {
      if (httpContext != null)
      {
        httpContext.Request.Headers.TryGetValue("X-Pedido-Sessao", out StringValues pedidoFromHeader);
        context.PedidoIdSessao = (pedidoFromHeader.Count <= 0) ? 0 : int.Parse(pedidoFromHeader.ToString());
      }
    }

  }

}
