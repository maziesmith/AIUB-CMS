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

        AdminDataDataContext StudentDataContext;

        public StudentDataHandler()
        {
            this.StudentDataContext = new AdminDataDataContext();
        }

        public StudentDataHandler(string id)
        {
            this.id = id;
            this.StudentDataContext = new AdminDataDataContext();
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

        public void InsertStudent()
        {
            var newStudent = new Test_StudentTable();
            newStudent.Name = this.name;
            newStudent.CGPA = this.CGPA;
            newStudent.Credits = this.credit;
            newStudent.Program = this.program;
            newStudent.Department = this.department;
            newStudent.FatherName = this.father;
            newStudent.MotherName = this.mother;
            newStudent.Phone = this.phone;
            newStudent.Email = this.email;
            newStudent.BloodGroup = this.bloodGroup;
            newStudent.Gender = this.gender;
            newStudent.ID = this.id;
            newStudent.DOB = Convert.ToDateTime(this.dob);
            StudentDataContext.Test_StudentTables.InsertOnSubmit(newStudent);
            StudentDataContext.SubmitChanges();
        }

        public void UpdateStudent()
        {
            var newStudent = StudentDataContext.Test_StudentTables.SingleOrDefault(s => s.ID == id);
            newStudent.Name = this.name;
            newStudent.CGPA = this.CGPA;
            newStudent.Credits = this.credit;
            newStudent.Program = this.program;
            newStudent.Department = this.department;
            newStudent.FatherName = this.father;
            newStudent.MotherName = this.mother;
            newStudent.Phone = this.phone;
            newStudent.Email = this.email;
            newStudent.BloodGroup = this.bloodGroup;
            newStudent.Gender = this.gender;
            newStudent.ID = this.id;
            newStudent.DOB = Convert.ToDateTime(this.dob);
            StudentDataContext.SubmitChanges();
        }

        public void DeleteStudent()
        {
            var newStudent = StudentDataContext.Test_StudentTables.SingleOrDefault(s => s.ID == id);
            StudentDataContext.Test_StudentTables.DeleteOnSubmit(newStudent);
            StudentDataContext.SubmitChanges();
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

        public void SetDepartment(string value)
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
