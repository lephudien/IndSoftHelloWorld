using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDB.Oracle
{
  public class ReadFromDB
  {
    public static string GetMyVersion()
    {
      return "AdapterDB.OracleVer=1.2.0.0" + Environment.NewLine + "Using package Oracle.ManagedDataAccess 19.9";
    }
  }
}
