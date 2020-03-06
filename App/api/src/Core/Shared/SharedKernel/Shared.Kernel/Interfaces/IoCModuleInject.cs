using Microsoft.Extensions.DependencyInjection;

namespace Core.Shared.Kernel.Interfaces
{
  public interface IoCModuleInject
  {
    void InjectAll(IServiceCollection services);
  }
}
