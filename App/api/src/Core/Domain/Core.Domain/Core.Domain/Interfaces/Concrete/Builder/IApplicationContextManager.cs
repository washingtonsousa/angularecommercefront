using Core.Domain.Singleton;
using System.Threading.Tasks;

namespace Core.Domain.Interfaces
{
  public interface IApplicationContextManager
  {
    Task<ApplicationContext> getContext();
  }
}
