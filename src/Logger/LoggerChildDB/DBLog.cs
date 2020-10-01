using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerChildDB
{
  public class DBLog
  {
    public static string GetMyVersion()
    {
      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

      return "DBLogVer=" + fvi.FileVersion
              + Environment.NewLine 
              + "Using: " + AdapterDB.MSSSQL.ReadFromDB.GetMyVersion()
              + Environment.NewLine
              + "Using: " + AdapterDB.Oracle.ReadFromDB.GetMyVersion();
    }
  }
}
