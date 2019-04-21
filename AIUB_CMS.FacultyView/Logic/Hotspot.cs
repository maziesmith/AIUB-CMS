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
using System.Security.Cryptography;

namespace AIUB_CMS.FacultyView.Logic
{
    class Hotspot
    {
        public Hotspot()
        {
            // Do nothing.
        }

        public void StartHotspot(string SSID, string password)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            Process process = Process.Start(processStartInfo);
            process.StandardInput.WriteLine("arp -d *");
            process.StandardInput.WriteLine("netsh wlan set hostednetwork mode=allow ssid=" + SSID + " key=" + password);
            process.StandardInput.WriteLine("netsh wlan start hosted network");
            process.StandardInput.Close();
            MessageBox.Show("Hotspot Started.");
        }

        public void GenerateStudentList()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            Process process = Process.Start(processStartInfo);
            process.StandardInput.WriteLine("cd C:\\Users\\Saqibur Rahman\\Desktop\\AIUB-CMS\\TestingData");
            process.StandardInput.WriteLine("arp -a >> studentList.txt");
            process.StandardInput.Close();
            Console.WriteLine("Student List Updated.");
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
            MessageBox.Show("Hotspot Stopped.");
        }

        public string GetUniqueKey(int size)
        {
            char[] chars =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[size];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(data);
            }
            StringBuilder result = new StringBuilder(size);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        //public static bool IsAdmin()
        //{
        //    WindowsIdentity id = WindowsIdentity.GetCurrent();
        //    WindowsPrincipal p = new WindowsPrincipal(id);
        //    return p.IsInRole(WindowsBuiltInRole.Administrator);
        //}
    }
}
