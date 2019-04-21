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
            string id = this.textboxStudentID.Text;
            StudentDataHandler studentData = new StudentDataHandler(id);

            // this..Text = studentData.GetProgram();
            this.textboxStudentPhone.Text = studentData.GetPhone();
            this.textboxStudentName.Text = studentData.GetName();
            this.textboxStudentMother.Text = studentData.GetMother();
            // this.textboxID.Text = studentData.GetID();
            // this..Text = studentData.GetGender().ToString();
            this.textboxStudentFather.Text = studentData.GetFather();
            this.textboxStudentEmail.Text = studentData.GetEmail();
            // this.labelDOBAns.Text = studentData.GetDOB();
            // this.labelDepartmentAns.Text = studentData.GetDepartment();
            this.textboxStudentCreditsCompleted.Text = studentData.GetCredit().ToString();
            this.textboxStudentCGPA.Text = studentData.GetCGPA().ToString();
            // this.labelBloodGroupAns.Text = studentData.GetBloodGroup().ToString();
        }

        private void buttonCreateStudent_Click(object sender, EventArgs e)
        {
            string id = this.textboxStudentID.Text;
            StudentDataHandler studentData = new StudentDataHandler(id);
            // this..Text = studentData.SetProgram();
            studentData.SetPhone(this.textboxStudentPhone.Text);
            studentData.SetName(this.textboxStudentName.Text);
            studentData.SetMother(this.textboxStudentMother.Text);
            studentData.SetID(this.textboxStudentID.Text);
            // this..Text = studentData.SetGender().ToString();
            studentData.SetFather(this.textboxStudentFather.Text);
            studentData.SetEmail(this.textboxStudentEmail.Text);
            // this.labelDOBAns.Text = studentData.SetDOB();
            // this.labelDepartmentAns.Text = studentData.SetDepartment();
            studentData.SetCredit(Convert.ToInt32(this.textboxStudentCreditsCompleted.Text));
            studentData.SetCGPA(Convert.ToDouble(this.textboxStudentCGPA.Text));
            // this.labelBloodGroupAns.Text = studentData.SetBloodGroup().ToString();
            studentData.InsertStudent();
        }
    }
}
