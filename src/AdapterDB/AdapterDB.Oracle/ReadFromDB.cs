using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDB.Oracle2
{
  public class ReadFromDB
  {
    public static string GetMyVersion()
    {
      int a = Common.Constants.CONSTANTY.C_NEJAKA_VERZE;

      var test = new Oracle.ManagedDataAccess.Client.OracleConnection();
      //Debug.Assert(test == null);
      var test2 = new NUnit.Framework.Api.FrameworkController("a", "b", null);

      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

      return $"AdapterDB.OracleVer={fvi.FileVersion}{Environment.NewLine}Using EXTERNAL Oracle.ManagedDataAccess 19.9{Environment.NewLine}Using NUNIT and CommonId: {a}";


    }
  }
}
