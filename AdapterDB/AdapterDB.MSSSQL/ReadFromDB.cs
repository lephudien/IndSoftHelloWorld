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
      return "AdapterDB.MSSSQLVer=1.1.0.0" + Environment.NewLine + "Using package System.Data.SqlClient 4.8.2";
    }
  }
}
