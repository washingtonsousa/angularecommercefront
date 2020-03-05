using AutoMapper;
using Core.Application.Abstractions;
using Core.Application.Interfaces;
using Core.BaseWeb.ViewModel;
using Core.Domain.Interfaces;
using System.Threading.Tasks;

namespace Core.Application
{
  public class LojaAppService : ApplicationService, ILojaAppService
  {
    public LojaAppService(IMapper mapper,
      IApplicationContextManager applicationContextManager)
      : base(mapper, applicationContextManager)
    {
    }

    public async Task<LojaviewModel>  GetDadosLoja()
    {
      var context = await _applicationContextManager.getContext();
      return _mapper.Map<LojaviewModel>(context.LojaInContext);
    }

  }
}
