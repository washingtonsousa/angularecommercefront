using AutoMapper;
using Core.Application;
using Core.Application.Interfaces;
using Core.Domain.Singleton;
using Core.BaseWeb.AutoMapper;
using Core.Data.EF.Context;
using Core.Data.Repository;
using Core.Domain.Repository.Interfaces.Concrete;
using Core.Domain.Interfaces;
using Core.Domain.Repository;
using Core.Domain.Repository.Interfaces;
using Core.Domain.Repository.UnityOfWork;
using Core.Shared.Kernel.Events;
using Core.Shared.Kernel.Handles;
using Core.Shared.Kernel.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Core.Infrastructure
{
  public static class IoCContainer
  {

    public static void InjectScoped(IServiceCollection services)
    {
      services.AddScoped<MainContext, MainContext>();
      services.AddScoped<IUnityOfWork, UnityOfWork>();
      services.AddScoped<IApplicationContextManager, ApplicationContextManager>();
      services.AddScoped<IAssertionConcern, AssertionConcern>();
      services.AddScoped<IDomainNotificationHandler<DomainNotification>, DomainNotificationHandler>();
      
    }

    public static void InjectDataRepositories(IServiceCollection services)
    {
      services.AddTransient<ICategoriaRepository, CategoriaRepository>();
      services.AddTransient<IDadosLojaRepository, DadosLojaRepository>();
      services.AddTransient<IClienteRepository, ClienteRepository>();
      services.AddTransient<IPracaRepository, PracaRepository>();
    }

    public static void InjectApplicationServices(IServiceCollection services)
    {
      services.AddTransient<IDepartamentoAppService, DepartamentoAppService>();
      services.AddTransient<IAuthenticationService, AuthenticationAppService>();
      services.AddTransient<IPracaAppService, PracaAppService>();
      services.AddTransient<ILojaAppService, LojaAppService>();
      services.AddTransient<IPedidoAppService, PedidoAppService>();
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

      services.AddSingleton(services.BuildServiceProvider());
      services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();

    }

  }
}
