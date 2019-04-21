using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_CMS.AdminView.Data
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

        AdminDataDataContext FacultyDataContext;

        public FacultyDataHandler()
        {
            this.FacultyDataContext = new AdminDataDataContext();
        }

        public FacultyDataHandler(string id)
        {
            this.id = id;
            this.FacultyDataContext = new AdminDataDataContext();
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

        public void InsertStudent()
        {
            var newFaculty = new Test_FacultyTable();
            newFaculty.Name = this.name;
            newFaculty.Department = this.department;
            newFaculty.FatherName = this.father;
            newFaculty.MotherName = this.mother;
            newFaculty.PhoneNumber = this.phone;
            newFaculty.Email = this.email;
            newFaculty.BloodGroup = this.bloodGroup;
            newFaculty.Gender = this.gender;
            newFaculty.ID = this.id;
            newFaculty.DOB = Convert.ToDateTime(this.dob);
            FacultyDataContext.Test_FacultyTables.InsertOnSubmit(newFaculty);
            FacultyDataContext.SubmitChanges();
        }

        public IQueryable GetStudentTable()
        {
            return FacultyDataContext.Test_FacultyTables;
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

        public void SetName(string value)
        {
            this.name = value;
        }

        public void SetCGPA(double value)
        {
            this.CGPA = value;
        }

        public void SetCredit(int value)
        {
            this.credit = value;
        }

        public void SetProgram(string value)
        {
            this.program = value;
        }

        public void SetDepartment(int value)
        {
            this.department = value;
        }

        public void SetMother(string value)
        {
            this.mother = value;
        }

        public void SetFather(string value)
        {
            this.father = value;
        }

        public void SetEmail(string value)
        {
            this.email = value;
        }

        public void SetPhone(string value)
        {
            this.phone = value;
        }

        public void SetBloodGroup(int value)
        {
            this.bloodGroup = value;
        }

        public void SetGender(int value)
        {
            this.gender = value;
        }

        public void SetID(string value)
        {
            this.id = value;
        }

        public void SetDOB(string value)
        {
            this.dob = value;
        }
    }
}
