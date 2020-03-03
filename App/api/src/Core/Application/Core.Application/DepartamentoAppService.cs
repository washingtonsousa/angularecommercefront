
using AutoMapper;
using Core.Application.Abstractions;
using Core.Application.Interfaces;
using Core.BaseWeb.ViewModel;
using Core.Domain.Repository.Interfaces;
using Core.Domain.Repository.Interfaces.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Application
{
  public class DepartamentoAppService : ApplicationService, IDepartamentoAppService
  {

    public ICategoriaRepository _categoriaRepository;


    public DepartamentoAppService(IMapper mapper, IUnityOfWork unityOfWork, ICategoriaRepository categoriaRepository) : base(mapper, unityOfWork)
    {
      _categoriaRepository = categoriaRepository;
    }

    public async Task<IList<DepartamentoViewModel>> ObterMenuPrincipalDepartamentos()
    {

      IList<DepartamentoViewModel> departamentos = _mapper.Map<IList<DepartamentoViewModel>>(await _categoriaRepository.GetCategoriaDepartamentos());
      return departamentos;

    }

    
  }

}
