using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerChildText
{
  public class TextLog
  {
    public static string GetMyVersion()
    {
      return "AdapterDB.MSSSQLVer=1.3.5.0"
              + Environment.NewLine
              + "Using: " + AdapterFile.Text.TextRW.GetMyVersion();
    }
  }
}
