using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPackageOldStyle
{
  public class Test
  {
    public static string GetMyVersion()
    {
      var test = new Google.Apis.Logging.ConsoleLogger(Google.Apis.Logging.LogLevel.All); ;
      //Debug.Assert(test == null);

      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

      return $"TestPackageOldStyleVer={fvi.FileVersion} {Environment.NewLine} Using package Google.Apis.Logging";


    }
  }
}
