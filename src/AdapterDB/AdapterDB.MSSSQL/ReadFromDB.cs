using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDB.MSSSQL
{
  public class ReadFromDB
  {
    public static string GetMyVersion()
    {
      var test = new System.Data.SqlClient.SqlConnection();
      //Debug.Assert(test == null);
      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
      
      return $"AdapterDB.MSSSQLVer={fvi.FileVersion}{Environment.NewLine}Using EXTERNAL System.Data.SqlClient 4.8.2";
    }
  }
}
