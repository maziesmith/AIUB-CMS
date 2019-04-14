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

namespace AIUB_CMS.FacultyView.Interface
{
    public partial class FacultyInterface : MetroFramework.Forms.MetroForm
    {
        public FacultyInterface()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Hotspot hotspot = new Hotspot(this.textboxSSID.Text, this.textboxPassword.Text);
            hotspot.GenerateStudentList();
        }
    }
}
