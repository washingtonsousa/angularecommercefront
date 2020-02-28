
using AutoMapper;
using Marketplace.Core.Application.Interfaces;
using Marketplace.Core.BaseWeb.ViewModel;
using Marketplace.Core.Domain.EF.Entities;
using Marketplace.Core.Domain.Repository.Interfaces.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marketplace.Core.Application
{
  public class DepartamentoAppService : IDepartamentoAppService
  {
    public ICategoriaRepository _categoriaRepository { get; }

    public DepartamentoAppService(ICategoriaRepository categoriaRepository)
    {
      _categoriaRepository = categoriaRepository;
    }

    public async Task<IList<Categoria>> ObterMenuPrincipalDepartamentos()
    {

      IList<Categoria> departamentos = await _categoriaRepository.GetCategoriaDepartamentos();
      return departamentos;

    }

    
  }

}
