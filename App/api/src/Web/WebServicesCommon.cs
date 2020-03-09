using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Core.Domain.Interfaces.Concrete.Repository;
using Core.Domain.Repository.Interfaces;
using Core.Shared.Kernel.Abstractions;
using Core.Shared.Kernel.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ApiWeb
{
  public static class WebServicesCommon
  {

    /// <summary>
    /// Responsável por incluir nos serviços os containers de todos os módulos referenciados na aplicação e instalar o módulo do assembly referenciado caso não esteja instalado
    /// </summary>
    /// <param name="services"></param>
    public static void InjectServiceModules(this IServiceCollection services, IServiceProvider provider)
    {

      var contextManager = provider.GetService<IApplicationContextManager>();
      var unityOfWork = provider.GetService<IUnityOfWork>();
      var moduleRepository = provider.GetService<IApplicationModuleRepository>();

      var netCoreBinFolder = "netcoreapp" + System.Environment.Version.ToString().Substring(0, 3);

      string binFolder = Directory.GetCurrentDirectory() + $@"\bin\Debug\{netCoreBinFolder}";

      IList<string> fileList = Directory.GetFiles(binFolder).ToList().Select(f => f.Split(@"\".ToCharArray()).Last()).ToList();

      fileList = fileList.Where(p => p.IsModuleDll()).ToList();

      IList<ApplicationModule> Modules = contextManager.getContext().GetAwaiter().GetResult().Modules;

      foreach (string fileName in fileList)
      {

        ApplicationModule moduleFromDatabase = Modules.Where(m => m.Name == fileName.GetModuleRealName()).FirstOrDefault();

        var ass = Assembly.LoadFrom(binFolder + @"\" + fileName);

        IEnumerable<Type> types = ass.GetTypes().Where(a => a.IsSubclassOf(typeof(ApplicationModule)));

        //Removidos tipos abstratos da lista
        var container = types.Where(t => t.IsAbstract == false && t.Name == fileName.GetModuleMainClassName()).FirstOrDefault();

        /////Containers instanciados e dependencias incluidas no container principal da aplicação
        if (container != null)
        {
          ApplicationModule instance = (ApplicationModule)Activator.CreateInstance(container);

          if (moduleFromDatabase == null)
          {

            instance.execInstall();
            moduleRepository.Add(instance).GetAwaiter().GetResult();
            unityOfWork.Commit();

          }
          else
          {
            if (moduleFromDatabase.IsActivated)
              instance.InjectAll(services);
          }
        }
      }

      services.AddSingleton(services.BuildServiceProvider());

    }

  }
}
