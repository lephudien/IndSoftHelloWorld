using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdapterFile.Binary
{
  public class BinaryRW
  {
    public static string GetMyVersion()
    {
      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
      //Assembly.GetExecutingAssembly().GetReferencedAssemblies()

      return $"AdapterFile.BinaryVer={fvi.FileVersion}{Environment.NewLine}Using Google.Apis.Core";
    }
  }
}
