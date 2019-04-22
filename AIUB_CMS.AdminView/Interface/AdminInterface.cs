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

        public enum Nationality
        {
            Bangladeshi,
            Chinese,
            Indian,
            Japanese
        };

        string studentImageURL;
        public AdminInterface()
        {
            // Do nothing.
            
        }

        private void UpdateForm()
        {
            StudentDataHandler studentData = new StudentDataHandler();
            this.datagridStudentTable.DataSource = studentData.GetStudentTable();
        }

        public AdminInterface(string id)
        {
            InitializeComponent();

            foreach(var bg in Enum.GetValues(typeof(BloodGroup)))
            {
                comboboxAdminBloodGroup.Items.Add(bg);
                comboboxFacultyBloodGroup.Items.Add(bg);
                comboboxStudentBloodGroup.Items.Add(bg);
            }

            foreach (var nationality in Enum.GetValues(typeof(Nationality)))
            {
                comboboxAdminNationality.Items.Add(nationality);
                comboboxFacultyNationality.Items.Add(nationality);
                comboboxStudentNationality.Items.Add(nationality);
            }

            AdminDataHandler adminData = new AdminDataHandler(id);
            StudentDataHandler studentData = new StudentDataHandler();

            this.labelPhoneAns.Text = adminData.GetPhone();
            this.labelNameAns.Text = adminData.GetName();
            this.labelMotherAns.Text = adminData.GetMother();
            this.labelIDAns.Text = adminData.GetID();
            this.labelGenderAns.Text = adminData.GetGender().ToString();
            this.labelFatherAns.Text = adminData.GetFather();
            this.labelEmailAns.Text = adminData.GetEmail();
            this.labelDOBAns.Text = adminData.GetDOB();
            this.labelBloodGroupAns.Text = adminData.GetBloodGroup().ToString();

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

            if (studentData.GetGender() == 1)
                radiobuttonStudentMale.Checked = true;
            else
                radiobuttonStudentFemale.Checked = true;

            this.textboxStudentFather.Text = studentData.GetFather();
            this.textboxStudentEmail.Text = studentData.GetEmail();
            // this.labelDOBAns.Text = studentData.GetDOB();
            // this.labelDepartmentAns.Text = studentData.GetDepartment();
            this.textboxStudentCreditsCompleted.Text = studentData.GetCredit().ToString();
            this.textboxStudentCGPA.Text = studentData.GetCGPA().ToString();
            // this.labelBloodGroupAns.Text = studentData.GetBloodGroup().ToString();
            this.pictureboxStudentPicture.ImageLocation = studentData.GetImageDirectory();
            // this.pictureboxStudentPicture.Load();
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
            studentData.SetImageDirectory(studentImageURL);
            studentData.InsertStudent();
            UpdateForm();
            MessageBox.Show("Student Created");
        }

        private void textboxFacultyID_Click(object sender, EventArgs e)
        {
            
        }

        private void datagridStudentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonStudentBrowseImage_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openfiledialogImageSelection.ShowDialog();

            if (result == DialogResult.OK)
            {
                studentImageURL = openfiledialogImageSelection.FileName;
            }


            pictureboxStudentPicture.ImageLocation = studentImageURL;
        }

        private void buttonUpdateStudent_Click(object sender, EventArgs e)
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
            studentData.SetImageDirectory(studentImageURL);
            studentData.UpdateStudent();
            UpdateForm();
            MessageBox.Show("Student Updated");
        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            string id = this.textboxStudentID.Text;
            StudentDataHandler studentData = new StudentDataHandler(id);
            studentData.DeleteStudent();
            UpdateForm();
            MessageBox.Show("Student Deleted");
        }

        private void buttonGetAdmin_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateAdmin_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateAdmin_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
