using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIUB_CMS.FacultyView.Logic;
using AIUB_CMS.FacultyView.Data;
using System.IO;

namespace AIUB_CMS.FacultyView.Interface
{
    public partial class FacultyInterface : MetroFramework.Forms.MetroForm
    {
        Hotspot hotspot;

        public FacultyInterface()
        {
            // Do nothing.
        }

        public FacultyInterface(string id)
        {
            InitializeComponent();

            FacultyDataHandler facultyData = new FacultyDataHandler(id);
            hotspot = new Hotspot();

            this.labelPhoneAns.Text = facultyData.GetPhone();
            this.labelNameAns.Text = facultyData.GetName();
            this.labelMotherAns.Text = facultyData.GetMother();
            this.labelIDAns.Text = facultyData.GetID();
            this.labelGenderAns.Text = facultyData.GetGender().ToString();
            this.labelFatherAns.Text = facultyData.GetFather();
            this.labelEmailAns.Text = facultyData.GetEmail();
            this.labelDOBAns.Text = facultyData.GetDOB();
            this.labelDepartmentAns.Text = facultyData.GetDepartment().ToString();
            this.labelBloodGroupAns.Text = facultyData.GetBloodGroup().ToString();
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            hotspot.StartHotspot(this.textboxSSID.Text, this.textboxPassword.Text);
            // hotspot.GenerateStudentList();
            timerForHotspot.Start();
            await Task.Delay(10000);
            hotspot.StopHotspot();
            timerForHotspot.Stop();

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            // hotspot.GenerateStudentList();
            //string macList = File.ReadAllText("C:\\Users\\Saqibur Rahman\\Desktop\\AIUB-CMS\\TestingData\\studentList.txt");
            //this.richTextBox1.Text = macList;

            MacParser macParser = new MacParser();
            List<string> studentList = macParser.ParseForMacAddress("C:\\Users\\Saqibur Rahman\\Desktop\\AIUB-CMS\\TestingData\\studentList.txt");

            foreach(string student in studentList)
            {
                this.richTextBox1.AppendText("\n" + student);
            }

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            hotspot.StopHotspot();
            timerForHotspot.Stop();
        }

        private void buttonAutoCredentials_Click(object sender, EventArgs e)
        {
            this.textboxSSID.Text = hotspot.GetUniqueKey(8);
            this.textboxPassword.Text = hotspot.GetUniqueKey(8);
        }

        private void timerForHotspot_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("tick");
            hotspot.GenerateStudentList();
            //string macList = File.ReadAllText("C:\\Users\\Saqibur Rahman\\Desktop\\AIUB-CMS\\TestingData\\studentList.txt");
            //this.richTextBox1.Text = macList;
        }
    }
}