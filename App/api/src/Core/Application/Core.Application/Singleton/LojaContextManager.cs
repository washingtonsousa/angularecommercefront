
using Core.Application.Interfaces;
using Core.Data.Repository.Interfaces.Concrete;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using Microsoft.Extensions.Primitives;

namespace Core.Application.Singleton
{
  public class ApplicationContextManager : IApplicationContextManager
  {

    public  ApplicationContext _context;
    private readonly IDadosLojaRepository _dadosLojaRepository;
    private readonly IPracaRepository _pracaRepository;
    private readonly IHttpContextAccessor _httpContextAccessor;
    public ApplicationContextManager(IDadosLojaRepository dadosLojaRepository,
      IPracaRepository pracaRepository,
      IHttpContextAccessor httpContextAccessor)
    {
      _dadosLojaRepository = dadosLojaRepository;
      _pracaRepository = pracaRepository;
      _httpContextAccessor = httpContextAccessor;

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

      context.LojaInContext = await _dadosLojaRepository.GetFirstRecord();
      context.UserInContext = _httpContextAccessor.HttpContext.User;
      await GetCurrentPraca(context);
      GetCurrentPedidoId(context);

      return context;

    }

    private  async Task GetCurrentPraca(ApplicationContext context)
    {
      _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("X-Loja-Id", out StringValues pracaFromheader);
      int pracaId = (pracaFromheader.Count <= 0) ? 0 : int.Parse(pracaFromheader.ToString());
      context.PracaAtual = await _pracaRepository.Get(pracaId);
    }


    private  void GetCurrentPedidoId(ApplicationContext context)
    {
      _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("X-Pedido-Sessao", out StringValues pedidoFromHeader);
      context.PedidoIdSessao = (pedidoFromHeader.Count <= 0) ? 0 : int.Parse(pedidoFromHeader.ToString());
    }

  }

}
