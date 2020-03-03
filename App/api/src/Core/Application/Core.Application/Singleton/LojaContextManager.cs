
using Core.Application.Interfaces;
using Core.Data.Repository.Interfaces.Concrete;
using System.Threading.Tasks;

namespace Core.Application.Singleton
{
  public class ApplicationContextManager : IApplicationContextManager
  {

    public static ApplicationContext _context;
    private readonly IDadosLojaRepository _dadosLojaRepository;
    public ApplicationContextManager(IDadosLojaRepository dadosLojaRepository)
    {
      _dadosLojaRepository = dadosLojaRepository;

    }

    public async Task<ApplicationContext> getContext()
    {

      if (_context == null)
        _context = await buildLojaContext();

      return _context;

    }

    private async Task<ApplicationContext> buildLojaContext()
    {

      ApplicationContext context = new ApplicationContext();
      context.LojaInContext = await _dadosLojaRepository.GetFirstRecord();

      return context;

    }

  }

}
