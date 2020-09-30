using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommModuleCore
{
  public class CommCore
  {
    public static string GetMyVersion()
    {
      return "CommCoreVer=3.2.1.0" + Environment.NewLine + "Using CommExtensions: " + CommModuleExtensions.CommExtensions.GetMyVersion();
    }
  }
}
