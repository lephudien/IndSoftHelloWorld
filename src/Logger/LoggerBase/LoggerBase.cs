﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerBase
{
  public class LoggerBase
  {
    public static string GetMyVersion()
    {
      //var test = new System.Data.SqlClient.SqlConnection();
      //Debug.Assert(test == null);
      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

      return "LoggerBaseVer=" + fvi.FileVersion;
    }
  }
}
