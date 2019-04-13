using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_CMS.AdminView.Data
{
    class StudentDataHandler
    {
        private string name;
        private string id;
        private double CGPA;
        private int credit;
        private string program;
        private string department;
        private string father;
        private string mother;
        private string phone;
        private string email;
        private int gender;
        private int bloodGroup;
        private string dob;

        StudentDataDataContext StudentDataContext;

        public StudentDataHandler()
        {
            this.StudentDataContext = new StudentDataDataContext();
        }

        public StudentDataHandler(string id)
        {
            this.id = id;
            this.StudentDataContext = new StudentDataDataContext();
            var StudentInformation = from student in StudentDataContext.Test_StudentTables
                                     where student.ID == id
                                     select student;
            StudentInformation.ToList();
            foreach (var data in StudentInformation)
            {
                this.name = data.Name;
                this.CGPA = (double)data.CGPA;
                this.credit = data.Credits ?? 0;
                this.program = data.Program;
                this.department = data.Department;
                this.father = data.FatherName;
                this.mother = data.MotherName;
                this.phone = data.Phone;
                this.email = data.Email;
                this.bloodGroup = data.BloodGroup ?? 1;
                this.gender = data.Gender ?? 1;
                this.dob = data.DOB.ToString();

            }
        }

        public IQueryable GetStudentTable()
        {
            return StudentDataContext.Test_StudentTables;
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

        public string GetDepartment()
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
