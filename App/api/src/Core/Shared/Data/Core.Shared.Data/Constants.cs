using Core.Shared.Kernel.Extensions;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Core.Shared.Data
{
  public static class Constants
  {

    public static bool IsDebug;


    public static string NetCoreBinFolder
    {

      get { return "netcoreapp" + System.Environment.Version.ToString().Substring(0, 3); }

    }

    public static string BinFolder
    {

      get
      {
        return Directory.GetCurrentDirectory() + ((IsDebug) ? @"\bin\Debug\" : @"\bin\") + NetCoreBinFolder;
      }
    }

    public static IList<string> BinFileList
    {
      get
      {
        return Directory.GetFiles(BinFolder).ToList().Select(f => f.Split(@"\".ToCharArray()).Last()).ToList();
      }
    }
    public static IList<string> DllFileList
    {
      get
      {
        return BinFileList.Where(p => p.IsDll()).ToList();

      }
    }
    public static IList<string> ModuleDllList
    {
      get
      {
       return BinFileList.Where(p => p.IsModuleDll()).ToList();
      }
    }
  }
}
