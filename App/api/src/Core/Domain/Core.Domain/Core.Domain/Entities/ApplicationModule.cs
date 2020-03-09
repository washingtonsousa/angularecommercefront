using Core.Shared.Kernel.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Domain.Entities
{
  public class ApplicationModule : IModule
  {

    [Key]
    public int IdModule { get; set; }
    public string Name { get; set; }
    public string PackageName { get; set; }
    public string Description { get; set; }
    public bool IsActivated { get; set; }

    protected virtual void Install()
    {
      //IsActivated = true;
      ///You can Override as You Want 
    }

    public void execInstall()
    {
        Install();
    }

    public virtual void InjectAll(IServiceCollection services)
    {
      services.AddTransient(GetType());
    }

    public ApplicationModule()
    {
    }

  }
}
