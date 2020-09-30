using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDB.Oracle
{
  public class ReadFromDB
  {
    public static string GetMyVersion()
    {
      var test = new OracleNotificationSource();
      Debug.Assert(test == null);
      
      return "AdapterDB.OracleVer=1.3.5.0" + Environment.NewLine + "Using package Oracle.ManagedDataAccess 19.9";
    }
  }
}
