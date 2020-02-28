using Marketplace.Core.Domain.EF.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marketplace.Core.Application.Interfaces
{
  public interface IDepartamentoAppService
  {

    Task<IList<Categoria>> ObterMenuPrincipalDepartamentos();

  }
}
