﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AIUB_CMS.StudentView.Data
{
    class StudentDataHandler
    {
        private string name;
        private string id;
        private double CGPA;
        private int credit;
        private int department;
        private string father;
        private string mother;
        private string phone;
        private string email;
        private int gender;
        private int bloodGroup;
        private DateTime dob;

        StudentDataDataContext StudentDataContext;

        public StudentDataHandler()
        {
            // Do nothing.
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
                // this.program = data.Program;
                this.department = data.Department?? 1;
                this.father = data.FatherName;
                this.mother = data.MotherName;
                this.phone = data.Phone;
                this.email = data.Email;
                this.bloodGroup = data.BloodGroup?? 1;
                this.gender = data.Gender?? 1;
                this.dob = data.DOB?? DateTime.Now;

            }
        }

        public IQueryable GetStudentInfo(string id)
        {
            var StudentInformation = from student in StudentDataContext.Test_StudentTables
                                     where student.ID == id
                                     select student;
            return StudentInformation;
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
        public string GetDepartment()
        {
            StudentDataDataContext studentData = new StudentDataDataContext();
            string department = studentData.DepartmentTables.SingleOrDefault(s => s.DepartmentID == Convert.ToInt32(this.department)).DepartmentName;
            return department;
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
            return dob.ToShortDateString();
        }
    }
}
