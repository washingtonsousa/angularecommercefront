using Core.BaseWeb.ViewModel;
using Core.Domain.EF.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Application.Interfaces
{
  public interface IDepartamentoAppService
  {

    Task<IList<DepartamentoViewModel>> ObterMenuPrincipalDepartamentos();

  }
}
