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
      return "AdapterDB.MSSSQLVer=1.3.5.0" 
              + Environment.NewLine 
              + "Using: " + AdapterDB.MSSSQL.ReadFromDB.GetMyVersion()
              + Environment.NewLine
              + "Using: " + AdapterDB.Oracle.ReadFromDB.GetMyVersion();
    }
  }
}
