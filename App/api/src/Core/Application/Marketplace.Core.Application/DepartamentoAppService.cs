
using AutoMapper;
using Marketplace.Core.Application.Abstractions;
using Marketplace.Core.Application.Interfaces;
using Marketplace.Core.BaseWeb.ViewModel;
using Marketplace.Core.Domain.EF.Entities;
using Marketplace.Core.Domain.Repository.Interfaces;
using Marketplace.Core.Domain.Repository.Interfaces.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marketplace.Core.Application
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
