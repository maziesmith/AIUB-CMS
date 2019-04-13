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
using Google.GData.Calendar;
using AIUB_CMS.StudentView.Data;

namespace AIUB_CMS.StudentView.Interface
{
    public partial class StudentInterface : MetroFramework.Forms.MetroForm
    {
        public StudentInterface()
        {
            // Do nothing.
        }

        public StudentInterface(string id)
        {
            InitializeComponent();

            StudentDataHandler studentData = new StudentDataHandler(id);

            this.labelProgramAns.Text = studentData.GetProgram();
            this.labelPhoneAns.Text = studentData.GetPhone();
            this.labelNameAns.Text = studentData.GetName();
            this.labelMotherAns.Text = studentData.GetMother();
            this.labelIDAns.Text = studentData.GetID();
            this.labelGenderAns.Text = studentData.GetGender().ToString();
            this.labelFatherAns.Text = studentData.GetFather();
            this.labelEmailAns.Text = studentData.GetEmail();
            this.labelDOBAns.Text = studentData.GetDOB();
            this.labelDepartmentAns.Text = studentData.GetDepartment();
            this.labelCreditsAns.Text = studentData.GetCredit().ToString();
            this.labelCGPAAns.Text = studentData.GetCGPA().ToString();
            this.labelBloodGroupAns.Text = studentData.GetBloodGroup().ToString();
        }
    }
}
