using AutoMapper;
using Core.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Core.Shared.Data.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Linq;
using System;
using Core.Shared.Kernel.Abstractions;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using Core.Domain.Interfaces;
using System.Threading.Tasks;
using ApiWeb;
using Core.Shared.Data;

namespace FarmaciaMaisProxima
{
  public class Startup
  {
    public IWebHostEnvironment _environment { get; }
    public Startup(IConfiguration configuration, IWebHostEnvironment env)
    {
      Configuration = configuration;
      _environment = env;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {

      if(_environment.IsDevelopment())
        Constants.IsDebug = true;

      services.AddCors(options =>
      {
        options.AddPolicy("DefinedOrigins", builder =>
                                        {
                                          builder.AllowAnyHeader()
                                                       .AllowAnyMethod()
                                                       .WithOrigins("http://marketplace.vannon.local")
                                                       .AllowCredentials();
       }); });

      services.AddControllers().AddNewtonsoftJson(opt => {

      opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
      opt.SerializerSettings.ContractResolver = new DefaultContractResolver();
      }).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

      ConfigureAuthentication(services);

      //DI Configuration  
      services.AddSingleton(Configuration);
      services.AddAutoMapper(typeof(Startup));
      services.InjectAll();
      services.InjectServiceModules(services.BuildAppServiceProvider());

    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
     

      if (env.IsDevelopment())
      {
        app.UseCors(x => x
               .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());

        app.UseDeveloperExceptionPage();

      } else
      {
        app.UseCors("DefinedOrigins");
      }

      
      app.UseHttpsRedirection();
      app.UseRouting();
      app.UseAuthentication();
      app.UseAuthorization();

      app.UseEndpoints(end =>
      {
        end.MapControllers();
        end.MapControllerRoute("default", "v1/{controller}/{action}/{id?}");
      });

    }


    private void ConfigureAuthentication(IServiceCollection services)
    {
      var appSettingsSection = Configuration.GetSection("AppSettings");
      services.Configure<AppSettings>(appSettingsSection);
      var appSettings = appSettingsSection.Get<AppSettings>();
      var key = Encoding.ASCII.GetBytes(appSettings.AppSecret);

      services.AddAuthentication(x =>
      {
        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
      })
           .AddJwtBearer(x =>
           {
             x.RequireHttpsMetadata = false;
             x.SaveToken = true;
             x.TokenValidationParameters = new TokenValidationParameters
             {
               ValidateIssuerSigningKey = true,
               IssuerSigningKey = new SymmetricSecurityKey(key),
               ValidateIssuer = false,
               ValidateAudience = false
             };
           });
    }


  }
}
