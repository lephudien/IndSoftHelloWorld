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
      return "AdapterDB.MSSSQLVer=1.3.5.0" + Environment.NewLine + "Using: " + AdapterFile.Binary.BinaryRW.GetMyVersion();
    }
  }
}
