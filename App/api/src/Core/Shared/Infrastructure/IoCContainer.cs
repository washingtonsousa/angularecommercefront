using Core.Application;
using Core.Application.Interfaces;
using Core.Application.Singleton;
using Core.Data.EF.Context;
using Core.Data.Repository;
using Core.Data.Repository.Interfaces.Concrete;
using Core.Domain.Repository;
using Core.Domain.Repository.Interfaces;
using Core.Domain.Repository.Interfaces.Concrete;
using Core.Domain.Repository.UnityOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
  public static class IoCContainer
  {

    public static void InjectScoped(IServiceCollection services)
    {
      services.AddScoped<MainContext, MainContext>();
      services.AddScoped<IUnityOfWork, UnityOfWork>();
      services.AddScoped<IApplicationContextManager, ApplicationContextManager>();
    }

    public static void InjectDataRepositories(IServiceCollection services)
    {
      services.AddTransient<ICategoriaRepository, CategoriaRepository>();
      services.AddTransient<IDadosLojaRepository, DadosLojaRepository>();
    }

    public static void InjectApplicationServices(IServiceCollection services)
    {
      services.AddTransient<IDepartamentoAppService, DepartamentoAppService>();
    }

  }
}
