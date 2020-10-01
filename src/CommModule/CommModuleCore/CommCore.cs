using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommModuleCore
{
  public class CommCore
  {
    public static string GetMyVersion()
    {
      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

      return "CommCoreVer=" + fvi.FileVersion + Environment.NewLine + "Using CommExtensions: " + CommModuleExtensions.CommExtensions.GetMyVersion();
    }
  }
}
