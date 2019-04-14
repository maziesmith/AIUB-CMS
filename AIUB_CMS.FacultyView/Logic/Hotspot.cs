using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Principal;

namespace AIUB_CMS.FacultyView.Logic
{
    class Hotspot
    {
        private Hotspot()
        {
            // Do nothing.
        }

        public Hotspot(string SSID, string password)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.CreateNoWindow = false;
            processStartInfo.UseShellExecute = false;
            Process process = Process.Start(processStartInfo);

            process.StandardInput.WriteLine("netsh wlan set hostednetwork mode=allow ssid=" + SSID + " key=" + password);
            process.StandardInput.WriteLine("netsh wlan start hosted network");
            process.StandardInput.Close();
        }

        public void GenerateStudentList()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            Process process = Process.Start(processStartInfo);
            
            process.StandardInput.Close();
        }

        public void StopHotspot()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            Process process = Process.Start(processStartInfo);
            process.StandardInput.WriteLine("cd C:\\Users\\Saqibur Rahman\\Desktop\\AIUB-CMS\\TestingData");
            process.StandardInput.WriteLine("arp -a > studentList.txt");
            process.StandardInput.WriteLine("netsh wlan stop hosted network");
            process.StandardInput.Close();
        }

        //public static bool IsAdmin()
        //{
        //    WindowsIdentity id = WindowsIdentity.GetCurrent();
        //    WindowsPrincipal p = new WindowsPrincipal(id);
        //    return p.IsInRole(WindowsBuiltInRole.Administrator);
        //}
    }
}
