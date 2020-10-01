using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerChild1
{
  public class BinaryLog
  {
    public static string GetMyVersion()
    {
      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

      return "BinaryLogVer=" + fvi.FileVersion + Environment.NewLine + "Using: " + AdapterFile.Binary.BinaryRW.GetMyVersion();
    }
  }
}
