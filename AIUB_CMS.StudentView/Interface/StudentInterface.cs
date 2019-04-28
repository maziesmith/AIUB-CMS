using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIUB_CMS.StudentView.Data;

namespace AIUB_CMS.StudentView.Interface
{
    public partial class StudentInterface : MetroFramework.Forms.MetroForm
    {
        public enum BloodGroup
        {
            APos = 1,
            ANeg,
            BPos,
            BNeg,
            ABPos,
            ABNeg,
            OPos,
            ONeg
        };

        public StudentInterface()
        {
            // Do nothing.
        }

        public StudentInterface(string id)
        {
            InitializeComponent();
            StudentDataHandler studentData = new StudentDataHandler(id);
            this.Text = "Welcome, " + studentData.GetName();
            this.labelPhoneAns.Text = studentData.GetPhone();
            this.labelNameAns.Text = studentData.GetName();
            this.labelMotherAns.Text = studentData.GetMother();
            this.labelIDAns.Text = studentData.GetID();
            this.labelGenderAns.Text = studentData.GetGender() == 1 ? "Male" : "Female";
            this.labelFatherAns.Text = studentData.GetFather();
            this.labelEmailAns.Text = studentData.GetEmail();
            this.labelDOBAns.Text = studentData.GetDOB();
            this.labelDepartmentAns.Text = studentData.GetDepartment();
            this.labelCreditsAns.Text = studentData.GetCredit().ToString();
            this.labelCGPAAns.Text = studentData.GetCGPA().ToString();
            this.labelBloodGroupAns.Text = Enum.GetName(typeof(BloodGroup), studentData.GetBloodGroup());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
