using AutoMapper;
using Core.Application;
using Core.Application.Interfaces;
using Core.Application.Singleton;
using Core.BaseWeb.AutoMapper;
using Core.Data.EF.Context;
using Core.Data.Repository;
using Core.Data.Repository.Interfaces.Concrete;
using Core.Domain.Repository;
using Core.Domain.Repository.Interfaces;
using Core.Domain.Repository.Interfaces.Concrete;
using Core.Domain.Repository.UnityOfWork;
using Core.Shared.Kernel.Events;
using Core.Shared.Kernel.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Infrastructure
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
      services.AddTransient<IClienteRepository, ClienteRepository>();
    }

    public static void InjectApplicationServices(IServiceCollection services)
    {
      services.AddTransient<IDepartamentoAppService, DepartamentoAppService>();
      services.AddTransient<IAuthenticationService, AuthenticationAppService>();
   
    }

    public static void InjectServiceProviders(IServiceCollection services)
    {

      var mappingConfig = new MapperConfiguration(mc =>
      {
        mc.AddProfile(new DomainToViewModel());
        mc.AddProfile(new ViewModelToDomain());
      });

      IMapper mapper = mappingConfig.CreateMapper();
      services.AddSingleton(mapper);

      services.AddScoped<IDomainServiceContainerManager, DomainServiceContainerManager>();
    }

  }
}
