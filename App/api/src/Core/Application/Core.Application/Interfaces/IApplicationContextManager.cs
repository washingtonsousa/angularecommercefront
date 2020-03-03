using Core.Application.Singleton;
using System.Threading.Tasks;

namespace Core.Application.Interfaces
{
  public interface IApplicationContextManager
  {
    Task<ApplicationContext> getContext();

  }
}
