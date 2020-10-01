using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppServer
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

      System.Windows.Forms.MessageBox.Show("AppServerVer=" + fvi.FileVersion
                                            + Environment.NewLine
                                            + "Using: " + ServerClientComm.ServerClientComm.GetMyVersion()
                                            + Environment.NewLine
                                            + "Using: " + LoggerChildDB.DBLog.GetMyVersion()
                                            + Environment.NewLine
                                            + "Using: " + CommModuleCore.CommCore.GetMyVersion());
                                            /*
                                            + Environment.NewLine
                                            
                                            + "Using: " + AdapterDB.MSSSQL.ReadFromDB.GetMyVersion()
                                            + Environment.NewLine
                                            + "Using: " + AdapterDB.Oracle.ReadFromDB.GetMyVersion()
                                            + Environment.NewLine
                                            + "Using: " + AdapterFile.Binary.BinaryRW.GetMyVersion()
                                            + Environment.NewLine
                                            + "Using: " + AdapterFile.Text.TextRW.GetMyVersion()
                                            + Environment.NewLine
                                            + "Using: " + LoggerChildDB.DBLog.GetMyVersion()
                                            +Environment.NewLine
                                            + "Using: " + CommModuleCore.CommCore.GetMyVersion());*/
    }
  }
}
