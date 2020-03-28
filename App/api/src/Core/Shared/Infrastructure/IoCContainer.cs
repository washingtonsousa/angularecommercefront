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
using Core.Domain.Interfaces.Concrete.Services;
using Core.Domain.Services;
using Core.Domain.Specification;
using Core.Domain.Interfaces.Concrete.Repository;
using System;

namespace Core.Infrastructure
{
  public static class IoCContainer
  {

    public static void InjectAll(this IServiceCollection services)
    {
      InjectScoped(services);
      InjectDataRepositories( services);
      InjectApplicationServices( services);
      InjectDomainServices(services);
      InjectDomainSpecifications(services);
      InjectScoped( services);
      InjectDataRepositories(services);
      InjectExtensions(services);
    }

    public static void InjectScoped(this IServiceCollection services)
    {
      services.AddScoped<MainContext, MainContext>();
      services.AddScoped<IUnityOfWork, UnityOfWork>();
      services.AddScoped<IApplicationContextManager, ApplicationContextManager>();
      services.AddScoped<IDomainNotificationHandler<DomainNotification>, DomainNotificationHandler>();
    }

    public static void InjectDataRepositories(this IServiceCollection services)
    {
      services.AddTransient<ICategoriaRepository, CategoriaRepository>();
      services.AddTransient<IDadosLojaRepository, DadosLojaRepository>();
      services.AddTransient<IClienteRepository, ClienteRepository>();
      services.AddTransient<IPracaRepository, PracaRepository>();
      services.AddTransient<IApplicationModuleRepository, ApplicationModuleRepository>();
      services.AddTransient<IProdutoSkuPracaRepository, ProdutoSkuPracaRepository>();
    }

    public static void InjectDomainSpecifications(this IServiceCollection services)
    {
    }

    public static void InjectApplicationServices(this IServiceCollection services)
    {
      services.AddTransient<IDepartamentoAppService, DepartamentoAppService>();
      services.AddTransient<IAuthenticationService, AuthenticationAppService>();
      services.AddTransient<IPracaAppService, PracaAppService>();
      services.AddTransient<ILojaAppService, LojaAppService>();
      services.AddTransient<IPedidoAppService, PedidoAppService>();
      services.AddTransient<IClienteAppService, ClienteAppService>();
      services.AddTransient<ITokenService, TokenService>();
    }

    public static void InjectDomainServices(this IServiceCollection services)
    {
      services.AddTransient<IClienteService, ClienteService>();
    }

    public static void InjectExtensions(this IServiceCollection services)
    {

      services.AddSingleton(new MapperConfiguration(mc =>
      {
        mc.AddProfile(new DefaultMappingProfile());
      }).CreateMapper());

      services.AddScoped<IDomainEventContainer, DomainEvent>();
      services.AddSingleton(services.BuildServiceProvider());
      services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();

    }

    public static IServiceProvider BuildAppServiceProvider(this IServiceCollection services)
    {

      IServiceProvider provider = services.BuildServiceProvider();

      services.AddSingleton(provider);

      return provider;

    }

  }
}
