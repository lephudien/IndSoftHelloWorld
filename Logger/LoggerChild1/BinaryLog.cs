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
      //var test = new AdapterFile.Binary.;
      //Debug.Assert(test == null);

      return "AdapterDB.MSSSQLVer=1.3.5.0" + Environment.NewLine + "Using package System.Data.SqlClient 4.8.2";
    }
  }
}
