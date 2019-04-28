using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIUB_CMS.AdminView.Data;
using AIUB_CMS.AdminView.Logic;

namespace AIUB_CMS.AdminView.Interface
{
    public partial class AdminInterface : MetroFramework.Forms.MetroForm
    {

        public enum BloodGroup
        {
            APos,
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
            Japanese,
            American
        };

        string studentImageURL;
        string id;
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
            this.id = id;
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
            
            AdminDataHandler departmentData = new AdminDataHandler();
            List<string> departmentList = departmentData.GetDepartmentData();

            foreach (string dept in departmentList)
            {
                this.comboboxCourseDepartment.Items.Add(dept);
                this.comboboxFacultyDepartment.Items.Add(dept);
                this.comboboxStudentDepartment.Items.Add(dept);
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
            this.labelBloodGroupAns.Text = Enum.GetName(typeof(BloodGroup), adminData.GetBloodGroup());

            this.datagridStudentTable.DataSource = studentData.GetStudentTable();
        }

        private void buttonGetStudent_Click(object sender, EventArgs e)
        {
            string id = this.textboxStudentID.Text;
            LoadGetStudentInfo(id);
        }

        public void LoadGetStudentInfo(string id)
        {
            StudentDataHandler studentData = new StudentDataHandler(id);
            this.textboxStudentPhone.Text = studentData.GetPhone();
            this.textboxStudentName.Text = studentData.GetName();
            this.textboxStudentMother.Text = studentData.GetMother();
            this.textboxStudentID.Text = studentData.GetID();

            if (studentData.GetGender() == 1)
                radiobuttonStudentMale.Checked = true;
            else
                radiobuttonStudentFemale.Checked = true;

            this.textboxStudentFather.Text = studentData.GetFather();
            this.textboxStudentEmail.Text = studentData.GetEmail();
            this.datetimeStudentDOB.Value = studentData.GetDOB();
            this.comboboxStudentDepartment.SelectedIndex = studentData.GetDepartment();
            this.textboxStudentCreditsCompleted.Text = studentData.GetCredit().ToString();
            this.textboxStudentCGPA.Text = studentData.GetCGPA().ToString();
            this.comboboxStudentNationality.SelectedIndex = studentData.GetNationality();
            this.comboboxStudentBloodGroup.SelectedIndex = studentData.GetBloodGroup();
            this.pictureboxStudentPicture.ImageLocation = studentData.GetImageDirectory();
            this.textboxStudentMAC.Text = studentData.GetMAC();
            // this.pictureboxStudentPicture.Load();
        }

        private void buttonCreateStudent_Click(object sender, EventArgs e)
        {
            string id = this.textboxStudentID.Text;
            StudentDataHandler studentData = new StudentDataHandler(id);
            studentData.SetPhone(this.textboxStudentPhone.Text);
            studentData.SetName(this.textboxStudentName.Text);
            studentData.SetMother(this.textboxStudentMother.Text);
            studentData.SetID(this.textboxStudentID.Text);

            if (radiobuttonStudentMale.Checked)
                studentData.SetGender(1);
            else
                studentData.SetGender(2);

            studentData.SetFather(this.textboxStudentFather.Text);
            studentData.SetEmail(this.textboxStudentEmail.Text);
            studentData.SetDOB(this.datetimeStudentDOB.Value);
            studentData.SetDepartment(this.comboboxStudentDepartment.SelectedIndex);
            studentData.SetCredit(Convert.ToInt32(this.textboxStudentCreditsCompleted.Text));
            studentData.SetCGPA(Convert.ToDouble(this.textboxStudentCGPA.Text));
            studentData.SetBloodGroup(this.comboboxStudentBloodGroup.SelectedIndex);
            studentData.SetImageDirectory(studentImageURL);
            studentData.SetMAC(this.textboxStudentMAC.Text);
            studentData.SetPassword(GeneratePasswordHash.CalculateMD5Hash(this.textboxStudentPassword.Text));
            studentData.InsertStudent();
            UpdateForm();
            MessageBox.Show("Student Created");
        }

        private void textboxFacultyID_Click(object sender, EventArgs e)
        {
            
        }

        private void datagridStudentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.ColumnIndex);
            Console.WriteLine(e.RowIndex);
            string id = datagridStudentTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            LoadGetStudentInfo(id);
            this.tabControlAdmin.SelectTab(1);
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
            studentData.SetPhone(this.textboxStudentPhone.Text);
            studentData.SetName(this.textboxStudentName.Text);
            studentData.SetMother(this.textboxStudentMother.Text);
            studentData.SetID(this.textboxStudentID.Text);

            if (radiobuttonStudentMale.Checked)
                studentData.SetGender(1);
            else
                studentData.SetGender(2);

            studentData.SetFather(this.textboxStudentFather.Text);
            studentData.SetEmail(this.textboxStudentEmail.Text);
            studentData.SetDOB(this.datetimeStudentDOB.Value);
            studentData.SetDepartment(this.comboboxStudentDepartment.SelectedIndex);
            studentData.SetCredit(Convert.ToInt32(this.textboxStudentCreditsCompleted.Text));
            studentData.SetCGPA(Convert.ToDouble(this.textboxStudentCGPA.Text));
            studentData.SetBloodGroup(this.comboboxStudentBloodGroup.SelectedIndex);
            studentData.SetImageDirectory(studentImageURL);
            studentData.SetMAC(this.textboxStudentMAC.Text);
            studentData.SetPassword(GeneratePasswordHash.CalculateMD5Hash(this.textboxStudentPassword.Text));
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

        private void textboxSearchStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                StudentDataHandler studentData = new StudentDataHandler();
                if (Regex.IsMatch(textboxSearchStudent.Text, @"^[\p{L}]+$"))
                    this.datagridStudentTable.DataSource = studentData.SearchStudentByName(textboxSearchStudent.Text);
                // else if (textboxSearchStudent.Text.Length == 3)
                //     this.datagridStudentTable.DataSource = studentData.SearchStudentByDepartment(textboxSearchStudent.Text);
                else if (textboxSearchStudent.Text.Length > 0)
                    this.datagridStudentTable.DataSource = studentData.SearchStudentByID(textboxSearchStudent.Text);
                else
                    this.datagridStudentTable.DataSource = studentData.GetStudentTable();
            }
        }

        private void textboxFacultySearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                FacultyDataHandler facultyData = new FacultyDataHandler();
                if (Regex.IsMatch(textboxSearchStudent.Text, @"^[\p{L}]+$"))
                    this.datagridFacultyTable.DataSource = facultyData.SearchFacultyByName(textboxFacultySearch.Text);
                // else if (textboxSearchStudent.Text.Length == 3)
                //     this.datagridStudentTable.DataSource = studentData.SearchStudentByDepartment(textboxSearchStudent.Text);
                else if (textboxFacultySearch.Text.Length > 0)
                    this.datagridFacultyTable.DataSource = facultyData.SearchFacultyByID(textboxFacultySearch.Text);
                else
                    this.datagridFacultyTable.DataSource = facultyData.GetFacultyTable();
            }
        }

        private void buttonClearStudentInfo_Click(object sender, EventArgs e)
        {
            this.textboxStudentPhone.Text = "";
            this.textboxStudentName.Text = "";
            this.textboxStudentMother.Text = "";
            this.textboxStudentID.Text = "";
            radiobuttonStudentMale.Checked = true;
            this.textboxStudentFather.Text = "";
            this.textboxStudentEmail.Text ="";
            this.textboxStudentCreditsCompleted.Text = "";
            this.textboxStudentCGPA.Text = "";
            this.textboxStudentMAC.Text = "";
        }

        private void buttonGetFaculty_Click(object sender, EventArgs e)
        {
            string id = this.textboxFacultyID.Text;
            LoadGetFacultyInfo(id);
        }

        private void buttonCreateFaculty_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateFaculty_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteFaculty_Click(object sender, EventArgs e)
        {

        }
    }
}
