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

      return "AdapterDB.MSSSQLVer=1.3.5.1" + Environment.NewLine + "Using package System.Data.SqlClient 4.8.2";
    }
  }
}
