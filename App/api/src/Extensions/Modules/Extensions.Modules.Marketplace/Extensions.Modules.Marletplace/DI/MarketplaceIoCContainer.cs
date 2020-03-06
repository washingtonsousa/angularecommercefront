using Core.Shared.Kernel.Interfaces;
using Extensions.Modules.Marketplace.Application;
using Microsoft.Extensions.DependencyInjection;

namespace Extensions.Modules.Marketplace.DI
{
  public class MarketplaceIoCContainer : IoCModuleInject
  {
    public void InjectAll(IServiceCollection services)
    {
      services.AddTransient<MarketplaceVitrineAppService, MarketplaceVitrineAppService>();
    }
  }
}
