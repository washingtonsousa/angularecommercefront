using Core.BaseWeb.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Application.Interfaces
{
  public interface IVitrineAppService
  {

    Task<IList<VitrineViewModel>>  ObterVitrinesPrincipais();

  }
}
