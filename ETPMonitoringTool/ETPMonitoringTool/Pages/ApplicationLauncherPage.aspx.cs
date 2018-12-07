using Monitor.Service.Services;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETPMonitoringTool.Pages
{
    public partial class ClosedSessionPage : System.Web.UI.Page
    {


        public void btnOreceiver_Click(object sender, EventArgs e)
        {
            
                ProcessStartInfo processInfo = new ProcessStartInfo();
                processInfo.WindowStyle = ProcessWindowStyle.Hidden;
                processInfo.FileName = "cmd.exe";
                processInfo.WorkingDirectory = "C:\\";
                processInfo.Arguments = "/c START " + "NDP452-KB2901951-x86-x64-DevPack.exe";
                Process.Start(processInfo);
              

                }

        protected void btnTexecutor_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD.exe", "/K ipconfig");
        }

        protected void btnOreceiverstop_Click(object sender, EventArgs e)
        {
            Process.GetProcessesByName("processInfo")).kill();
          
               
            
        }

      
    }

}