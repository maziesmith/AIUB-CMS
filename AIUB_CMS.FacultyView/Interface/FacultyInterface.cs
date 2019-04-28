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

        string[] Times = { "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30",
                           "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30"};
        string[] Sections = { "A", "B", "C", "D", "E" };
        int[] Credits = { 1, 3, 4 };
        Hotspot hotspot;
        string id;
        public FacultyInterface()
        {
            // Do nothing.
        }

        public FacultyInterface(string id)
        {
            this.id = id;
            InitializeComponent();

            FacultyDataHandler facultyData = new FacultyDataHandler(id);
            hotspot = new Hotspot();

            this.Text = "Welcome, " + facultyData.GetName();
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


            foreach (var course in facultyData.GetCourseList())
            {
                this.comboboxCourses.Items.Add(course);
            }
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            hotspot.StartHotspot(this.textboxSSID.Text, this.textboxPassword.Text);
            // hotspot.GenerateStudentList();
            timerForHotspot.Start();
            await Task.Delay(20000);
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboboxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            FacultyDataHandler facultyData = new FacultyDataHandler(this.id);
            List<int?> CourseIDs =  facultyData.GetCourseIDs();

            string CourseName = comboboxCourses.SelectedItem.ToString();
            int ansCourseID = 0;
            foreach (var courseid in CourseIDs)
            {
                CourseDataHandler courseData1 = new CourseDataHandler(courseid?? 1);
                if (courseData1.GetName() == CourseName)
                {
                    ansCourseID = courseid?? 1;
                    break;
                }
            }
            CourseDataHandler courseData = new CourseDataHandler(ansCourseID);
            this.labelCourseIDAns.Text = courseData.GetID().ToString();
            this.labelCourseNameAns.Text = courseData.GetName().ToString();
            this.labelCourseNameAnswer.Text = courseData.GetName().ToString();
            this.labelDepartmentAns.Text = courseData.GetDepartment().ToString();

            if (courseData.GetDaySlot() == 1)
                this.labelDaysAns.Text = "Sun-Tues";
            else
                this.labelDaysAns.Text = "Mon-Wed";

            this.labelStartTimeEndTime.Text = Times[courseData.GetStartTime()] + " - " + Times[courseData.GetEndTime()];
            this.labelSectionAns.Text = Sections[courseData.GetSection()];

        }
    }
}