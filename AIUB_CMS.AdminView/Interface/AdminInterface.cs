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

        string[] Times = { "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30",
                           "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30"};
        string[] Sections = { "A", "B", "C", "D", "E" };
        int[] Credits = { 1, 3, 4 };

        string id;
        string studentImageURL;
        public AdminInterface()
        {
            // Do nothing.
            
        }

        private void UpdateForm()
        {
            StudentDataHandler studentData = new StudentDataHandler();
            FacultyDataHandler facultyData = new FacultyDataHandler();
            CourseDataHandler courseData = new CourseDataHandler();
            this.datagridStudentTable.DataSource = studentData.GetStudentTable();
            this.datagridFacultyTable.DataSource = facultyData.GetFacultyTable();
            this.datagridCourseTable.DataSource = courseData.GetCourseTable();
            string FacultyName = this.comboboxCourseAssignFaculty.SelectedItem.ToString();
            this.datagridFacultyCoursesAssigned.DataSource = courseData.GetFacultyCoursesAssigned(FacultyName);
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

            foreach(string time in Times)
            {
                this.comboboxCourseStartTime.Items.Add(time);
                this.comboboxCourseEndTime.Items.Add(time);
            }

            foreach (int credit in Credits)
            {
                this.comboboxCourseCredits.Items.Add(credit);
            }

            foreach (string section in Sections)
            {
                this.comboboxCourseSection.Items.Add(section);
            }

            AdminDataHandler adminData = new AdminDataHandler(id);
            StudentDataHandler studentData = new StudentDataHandler();
            FacultyDataHandler facultyData = new FacultyDataHandler();
            CourseDataHandler courseData = new CourseDataHandler();

            List<string> facultyList = facultyData.GetAllFaculty();

            foreach (string faculty in facultyList)
            {
                this.comboboxCourseAssignFaculty.Items.Add(faculty);
            }

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
            this.datagridFacultyTable.DataSource = facultyData.GetFacultyTable();
            this.datagridCourseTable.DataSource = courseData.GetCourseTable();
            this.datagridSearchAssignCourses.DataSource = courseData.GetAssignCourseTable();

            try
            {
                string FacultyName = this.comboboxCourseAssignFaculty.SelectedItem.ToString();
                
            }
            catch
            {
                string FacultyName = "n/a";
                this.datagridFacultyCoursesAssigned.DataSource = courseData.GetFacultyCoursesAssigned(FacultyName);
            }
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

        public void LoadGetFacultyInfo(string id)
        {
            FacultyDataHandler facultyData = new FacultyDataHandler(id);
            this.textboxFacultyPhone.Text = facultyData.GetPhone();
            this.texboxFacultyName.Text = facultyData.GetName();
            this.textboxFacultyID.Text = facultyData.GetID();
            this.textboxFacultyFather.Text = facultyData.GetFather();
            this.textboxFacultyMother.Text = facultyData.GetMother();
            this.textboxFacultyEmail.Text = facultyData.GetEmail();
            this.datetimeFacultyDOB.Value = facultyData.GetDOB();
            this.comboboxFacultyDepartment.SelectedIndex = facultyData.GetDepartment();
            this.comboboxFacultyBloodGroup.SelectedIndex = facultyData.GetBloodGroup();
            this.comboboxFacultyNationality.SelectedIndex = facultyData.GetNationality();
            
            if (facultyData.GetGender() == 1)
                radiobuttonFacultyMale.Checked = true;
            else
                radiobuttonFacultyFemale.Checked = true;

            // Image directory code required.
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
            // studentData.SetImageDirectory(studentImageURL);
            studentData.SetMAC(this.textboxStudentMAC.Text);
            studentData.SetPassword(GeneratePasswordHash.CalculateMD5Hash(this.textboxStudentPassword.Text));
            studentData.InsertStudent();
            UpdateForm();
            MessageBox.Show("Student Created");
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
                if (Regex.IsMatch(textboxFacultySearch.Text, @"^[\p{L}]+$"))
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
            string id = this.textboxFacultyID.Text;
            FacultyDataHandler facultyData = new FacultyDataHandler(id);
            facultyData.SetPhone(this.textboxFacultyPhone.Text);
            facultyData.SetName(this.texboxFacultyName.Text);
            facultyData.SetID(this.textboxFacultyID.Text);
            facultyData.SetFather(this.textboxFacultyFather.Text);
            facultyData.SetMother(this.textboxFacultyMother.Text);
            facultyData.SetEmail(this.textboxFacultyEmail.Text);
            facultyData.SetDOB(this.datetimeFacultyDOB.Value);
            facultyData.SetDepartment(this.comboboxFacultyDepartment.SelectedIndex);
            facultyData.SetBloodGroup(this.comboboxFacultyBloodGroup.SelectedIndex);
            facultyData.SetNationality(this.comboboxFacultyNationality.SelectedIndex);

            if (radiobuttonFacultyMale.Checked)
                facultyData.SetGender(1);
            else
                facultyData.SetGender(2);

            facultyData.SetPassword(GeneratePasswordHash.CalculateMD5Hash(this.textboxStudentPassword.Text));
            // studentData.SetImageDirectory(studentImageURL);
            facultyData.InsertFaculty();
            UpdateForm();
            MessageBox.Show("Faculty Created");
        }

        private void buttonUpdateFaculty_Click(object sender, EventArgs e)
        {
            string id = this.textboxFacultyID.Text;
            FacultyDataHandler facultyData = new FacultyDataHandler(id);
            facultyData.SetPhone(this.textboxFacultyPhone.Text);
            facultyData.SetName(this.texboxFacultyName.Text);
            facultyData.SetID(this.textboxFacultyID.Text);
            facultyData.SetFather(this.textboxFacultyFather.Text);
            facultyData.SetMother(this.textboxFacultyMother.Text);
            facultyData.SetEmail(this.textboxFacultyEmail.Text);
            facultyData.SetDOB(this.datetimeFacultyDOB.Value);
            facultyData.SetDepartment(this.comboboxFacultyDepartment.SelectedIndex);
            facultyData.SetBloodGroup(this.comboboxFacultyBloodGroup.SelectedIndex);
            facultyData.SetNationality(this.comboboxFacultyNationality.SelectedIndex);

            if (radiobuttonFacultyMale.Checked)
                facultyData.SetGender(1);
            else
                facultyData.SetGender(2);

            facultyData.SetPassword(GeneratePasswordHash.CalculateMD5Hash(this.textboxStudentPassword.Text));
            // studentData.SetImageDirectory(studentImageURL);
            facultyData.UpdateFaculty();
            UpdateForm();
            MessageBox.Show("Faculty Updated");
        }

        private void buttonDeleteFaculty_Click(object sender, EventArgs e)
        {
            string id = this.textboxFacultyID.Text;
            FacultyDataHandler facultyData = new FacultyDataHandler(id);
            facultyData.DeleteFaculty();
            UpdateForm();
            MessageBox.Show("Faculty Deleted");
        }

        private void datagridFacultyTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.ColumnIndex);
            Console.WriteLine(e.RowIndex);
            string id = datagridFacultyTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            LoadGetFacultyInfo(id);
            this.tabControlAdmin.SelectTab(3);
        }

        private void buttonoCourseCreate_Click(object sender, EventArgs e)
        {
            CourseDataHandler courseData = new CourseDataHandler();

            courseData.SetCredits(this.comboboxCourseCredits.SelectedIndex);
            courseData.SetDepartment(this.comboboxCourseDepartment.SelectedIndex);
            courseData.SetSection(this.comboboxCourseSection.SelectedIndex);
            courseData.SetStartTime(this.comboboxCourseStartTime.SelectedIndex);
            courseData.SetEndTime(this.comboboxCourseEndTime.SelectedIndex);
            courseData.SetName(this.textboxCourseName.Text);

            if (radiobuttonSundayTuesday.Checked)
                courseData.SetDaySlot(1);
            else
                courseData.SetDaySlot(2);

            courseData.InsertCourse();
            UpdateForm();
            MessageBox.Show("Course Created");
        }

        private void buttonCourseUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.textboxCourseID.Text);
            CourseDataHandler courseData = new CourseDataHandler(id);
            courseData.SetCredits(this.comboboxCourseCredits.SelectedIndex);
            courseData.SetDepartment(this.comboboxCourseDepartment.SelectedIndex);
            courseData.SetSection(this.comboboxCourseSection.SelectedIndex);
            courseData.SetStartTime(this.comboboxCourseStartTime.SelectedIndex);
            courseData.SetEndTime(this.comboboxCourseEndTime.SelectedIndex);
            courseData.SetName(this.textboxCourseName.Text);
            if (radiobuttonSundayTuesday.Checked)
                courseData.SetDaySlot(1);
            else
                courseData.SetDaySlot(2);
            courseData.UpdateCourse();
            UpdateForm();
            MessageBox.Show("Course Updated");
        }

        private void buttonCourseDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.textboxCourseID.Text);
            CourseDataHandler courseData = new CourseDataHandler(id);
            courseData.DeleteCourse();
            UpdateForm();
            MessageBox.Show("Course Deleted");
        }

        private void textboxCourseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                int id = Convert.ToInt32(this.textboxCourseID.Text);
                CourseDataHandler courseData = new CourseDataHandler(id);
                this.textboxCourseName.Text = courseData.GetName();
                this.comboboxCourseCredits.SelectedIndex = courseData.GetCredits();
                this.comboboxCourseDepartment.SelectedIndex = courseData.GetDepartment();
                this.comboboxCourseEndTime.SelectedIndex = courseData.GetEndTime();
                this.comboboxCourseSection.SelectedIndex = courseData.GetSection();
                this.comboboxCourseStartTime.SelectedIndex = courseData.GetStartTime();

                if (courseData.GetDaySlot() == 1)
                    radiobuttonSundayTuesday.Checked = true;
                else
                    radiobuttonMondayWednesday.Checked = true;
            }
        }

        private void datagridCourseTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.ColumnIndex);
            Console.WriteLine(e.RowIndex);
            int id = Convert.ToInt32(datagridCourseTable.Rows[e.RowIndex].Cells[0].Value);
            CourseDataHandler courseData = new CourseDataHandler(id);
            this.textboxCourseID.Text = courseData.GetID().ToString();
            this.textboxCourseName.Text = courseData.GetName();
            this.comboboxCourseCredits.SelectedIndex = courseData.GetCredits();
            this.comboboxCourseDepartment.SelectedIndex = courseData.GetDepartment();
            this.comboboxCourseEndTime.SelectedIndex = courseData.GetEndTime();
            this.comboboxCourseSection.SelectedIndex = courseData.GetSection();
            this.comboboxCourseStartTime.SelectedIndex = courseData.GetStartTime();

            if (courseData.GetDaySlot() == 1)
                radiobuttonSundayTuesday.Checked = true;
            else
                radiobuttonMondayWednesday.Checked = true;

            this.tabControlAdmin.SelectTab(5);
        }

        private void textboxCourseSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                CourseDataHandler courseData = new CourseDataHandler();
                if (Regex.IsMatch(textboxCourseSearch.Text, @"^[\p{L}]+$"))
                    this.datagridCourseTable.DataSource = courseData.SearchCourseByName(textboxCourseSearch.Text);
                else if (textboxCourseSearch.Text.Length > 0)
                    this.datagridCourseTable.DataSource = courseData.SearchCourseByID(Convert.ToInt32(textboxCourseSearch.Text));
                else
                    this.datagridCourseTable.DataSource = courseData.GetCourseTable();
            }
        }

        private void textboxSearchAssignCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                CourseDataHandler courseData = new CourseDataHandler();
                if (Regex.IsMatch(textboxSearchAssignCourse.Text, @"^[\p{L}]+$"))
                    this.datagridSearchAssignCourses.DataSource = courseData.SearchAssignCourseByName(textboxSearchAssignCourse.Text);
                else if (textboxSearchAssignCourse.Text.Length > 0)
                    this.datagridSearchAssignCourses.DataSource = courseData.SearchAssignCourseByID(Convert.ToInt32(textboxSearchAssignCourse.Text));
                else
                    this.datagridSearchAssignCourses.DataSource = courseData.GetAssignCourseTable();
            }
        }

        private void datagridSearchAssignCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(datagridCourseTable.Rows[e.RowIndex].Cells[0].Value);
            CourseDataHandler courseData = new CourseDataHandler(id);
            this.textboxCourseID.Text = courseData.GetID().ToString();
            this.textboxCourseName.Text = courseData.GetName();
            this.comboboxCourseCredits.SelectedIndex = courseData.GetCredits();
            this.comboboxCourseDepartment.SelectedIndex = courseData.GetDepartment();
            this.comboboxCourseEndTime.SelectedIndex = courseData.GetEndTime();
            this.comboboxCourseSection.SelectedIndex = courseData.GetSection();
            this.comboboxCourseStartTime.SelectedIndex = courseData.GetStartTime();

            if (courseData.GetDaySlot() == 1)
                radiobuttonSundayTuesday.Checked = true;
            else
                radiobuttonMondayWednesday.Checked = true;
        }

        private void comboboxCourseAssignFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseDataHandler courseData = new CourseDataHandler();
            string FacultyName = this.comboboxCourseAssignFaculty.SelectedItem.ToString();
            this.datagridFacultyCoursesAssigned.DataSource = courseData.GetFacultyCoursesAssigned(FacultyName);
        }

        private void buttonCourseAssign_Click(object sender, EventArgs e)
        {
            string FacultyName = this.comboboxCourseAssignFaculty.SelectedItem.ToString();
            int CourseID = Convert.ToInt32(textboxCourseID.Text);
        }
    }
}
