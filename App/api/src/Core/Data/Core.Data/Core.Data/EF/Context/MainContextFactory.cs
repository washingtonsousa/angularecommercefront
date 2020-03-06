using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Core.Data.EF.Context
{
  public class MainContextFactory : IDesignTimeDbContextFactory<MainContext>
  {

    private IConfiguration _configuration;

    public MainContextFactory()
    {

      //necessário para gerar as migrations para o contexto do EF
      var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
      _configuration = new ConfigurationBuilder()
           .SetBasePath(Path.Combine(Directory.GetCurrentDirectory() + $@"..\..\..\..\..\Web"))
           .AddJsonFile("appsettings.json", optional: false)
           .AddJsonFile($"appsettings.{envName}.json", optional: true)
           .Build(); ;
    }

    public MainContext CreateDbContext(string[] args)
    {
      var optionsBuilder = new DbContextOptionsBuilder<MainContext>();
      return new MainContext(_configuration, optionsBuilder.Options);
    }
  }
}
