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
using System.IO;

namespace AIUB_CMS.FacultyView.Interface
{
    public partial class FacultyInterface : MetroFramework.Forms.MetroForm
    {
        Hotspot hotspot;
        public FacultyInterface()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            hotspot = new Hotspot(this.textboxSSID.Text, this.textboxPassword.Text);
            // hotspot.GenerateStudentList();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            // hotspot.GenerateStudentList();
            string macList = File.ReadAllText("C:\\Users\\Saqibur Rahman\\Desktop\\AIUB-CMS\\TestingData\\studentList.txt");
            this.richTextBox1.Text = macList;

            if (macList.Contains("00-ec-0a-5f-38-a8"))
                MessageBox.Show("17-33863-1 is present.");
            else
                MessageBox.Show("17-33863-1 is absent.");
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            hotspot.StopHotspot();
        }
    }
}
