using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_CMS.FacultyView.Data
{
    class FacultyDataHandler
    {
        private string name;
        private string id;
        private double CGPA;
        private int credit;
        private string program;
        private int department;
        private string father;
        private string mother;
        private string phone;
        private string email;
        private int gender;
        private int bloodGroup;
        private string dob;

        FacultyDataDataContext FacultyDataContext;

        public FacultyDataHandler()
        {
            // Do nothing.
        }

        public FacultyDataHandler(string id)
        {
            this.id = id;
            this.FacultyDataContext = new FacultyDataDataContext();
            var FacultyInformation = from student in FacultyDataContext.Test_FacultyTables
                                     where student.ID == id
                                     select student;
            FacultyInformation.ToList();
            foreach (var data in FacultyInformation)
            {
                this.name = data.Name;
                this.department = data.Department ?? 1;
                this.father = data.FatherName;
                this.mother = data.MotherName;
                this.phone = data.PhoneNumber;
                this.email = data.Email;
                this.bloodGroup = data.BloodGroup ?? 1;
                this.gender = data.Gender ?? 1;
                this.dob = data.DOB.ToString();

            }
        }

        //public IQueryable GetStudentInfo(string id)
        //{
        //    var StudentInformation = from student in FacultyDataContext.Test_FacultyTables
        //                             where student.ID == id
        //                             select student;
        //    return StudentInformation;
        //}

        public List<string> GetCourseList()
        {
            var CourseID = from course in FacultyDataContext.Test_CourseAssignments
                           where course.FacultyID == this.id
                           select course.CourseID;
            CourseID.ToList();
            List<string> CourseList = new List<string>();

            foreach (var courseid in CourseID)
            {
                CourseList.Add(FacultyDataContext.Test_CourseTables.SingleOrDefault(c => c.ID == courseid).Name);
            }
            return CourseList;
            
        }

        public List<int?> GetCourseIDs()
        {
            var CourseID = from course in FacultyDataContext.Test_CourseAssignments
                           where course.FacultyID == this.id
                           select course.CourseID;
            
            return CourseID.ToList();
        }
        

        public string GetName()
        {
            return this.name;
        }

        public double GetCGPA()
        {
            return this.CGPA;
        }

        public int GetCredit()
        {
            return this.credit;
        }

        public string GetProgram()
        {
            return this.program;
        }

        public int GetDepartment()
        {
            return this.department;
        }

        public string GetMother()
        {
            return this.mother;
        }

        public string GetFather()
        {
            return this.father;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public string GetPhone()
        {
            return this.phone;
        }

        public int GetBloodGroup()
        {
            return this.bloodGroup;
        }

        public int GetGender()
        {
            return this.gender;
        }

        public string GetID()
        {
            return this.id;
        }

        public string GetDOB()
        {
            return this.dob;
        }
    }
}

