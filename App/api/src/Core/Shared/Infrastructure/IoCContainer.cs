using Marketplace.Core.Application;
using Marketplace.Core.Application.Interfaces;
using Marketplace.Core.Data.EF.Context;
using Marketplace.Core.Domain.Repository;
using Marketplace.Core.Domain.Repository.Interfaces;
using Marketplace.Core.Domain.Repository.Interfaces.Concrete;
using Marketplace.Core.Domain.Repository.UnityOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
  public static class IoCContainer
  {

    public static void InjectDataClasses(IServiceCollection services)
    {
      services.AddScoped<MainContext, MainContext>();
      services.AddScoped<IUnityOfWork, UnityOfWork>();
    }

    public static void InjectDataRepositories(IServiceCollection services)
    {
      services.AddTransient<ICategoriaRepository, CategoriaRepository>();
    }


    public static void InjectApplicationServices(IServiceCollection services)
    {
      services.AddTransient<IDepartamentoAppService, DepartamentoAppService>();
    }

  }
}
