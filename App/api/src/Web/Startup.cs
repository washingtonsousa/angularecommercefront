using AutoMapper;
using Infrastructure;
using Core.BaseWeb.AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FarmaciaMaisProxima
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {

      services.AddControllers().AddJsonOptions(jsonOptions =>
      {
        jsonOptions.JsonSerializerOptions.PropertyNamingPolicy = null;
      }).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

      //DI Configuration  
      services.AddSingleton(Configuration);
      services.AddAutoMapper(typeof(Startup));

      var mappingConfig = new MapperConfiguration(mc =>
      {
        mc.AddProfile(new DomainToViewModel());
        mc.AddProfile(new ViewModelToDomain());
      });

      IMapper mapper = mappingConfig.CreateMapper();
      services.AddSingleton(mapper);

      IoCContainer.InjectScoped(services);
      IoCContainer.InjectDataRepositories(services);
      IoCContainer.InjectApplicationServices(services);

    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseHttpsRedirection();
      app.UseRouting();
      app.UseAuthorization();
      app.UseEndpoints(end =>
      {

        end.MapControllerRoute("default", "v1/{controller}/{action}/{id?}");

      });

    }
  }
}
