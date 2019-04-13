using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIUB_CMS.AdminView.Data;

namespace AIUB_CMS.AdminView.Interface
{
    public partial class AdminInterface : MetroFramework.Forms.MetroForm
    {
        public AdminInterface()
        {
            InitializeComponent();
            StudentDataHandler studentData = new StudentDataHandler();
            this.datagridStudentTable.DataSource = studentData.GetStudentTable();
        }

        private void buttonGetStudent_Click(object sender, EventArgs e)
        {
            string id = this.textboxID.Text;
            StudentDataHandler studentData = new StudentDataHandler(id);

            // this..Text = studentData.GetProgram();
            this.textboxPhone.Text = studentData.GetPhone();
            this.textboxName.Text = studentData.GetName();
            this.textboxMother.Text = studentData.GetMother();
            // this.textboxID.Text = studentData.GetID();
            // this..Text = studentData.GetGender().ToString();
            this.textboxFather.Text = studentData.GetFather();
            this.textboxEmail.Text = studentData.GetEmail();
            // this.labelDOBAns.Text = studentData.GetDOB();
            // this.labelDepartmentAns.Text = studentData.GetDepartment();
            this.textboxCreditsCompleted.Text = studentData.GetCredit().ToString();
            this.textboxCGPA.Text = studentData.GetCGPA().ToString();
            // this.labelBloodGroupAns.Text = studentData.GetBloodGroup().ToString();
        }
    }
}
