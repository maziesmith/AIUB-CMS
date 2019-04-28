using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_CMS.AdminView.Data
{
    class AdminDataHandler
    {
        private string name;
        private string id;
        private string father;
        private string mother;
        private string phone;
        private string email;
        private int gender;
        private int bloodGroup;
        private string dob;
        private string password;

        AdminDataDataContext AdminDataContext;

        public AdminDataHandler()
        {
            this.AdminDataContext = new AdminDataDataContext();
        }

        public AdminDataHandler(string id)
        {
            this.id = id;
            this.AdminDataContext = new AdminDataDataContext();
            var AdminInformation = from student in AdminDataContext.Test_AdminTables
                                     where student.ID == id
                                     select student;
            AdminInformation.ToList();
            foreach (var data in AdminInformation)
            {
                this.name = data.Name;
                this.father = data.FatherName;
                this.mother = data.MotherName;
                this.phone = data.Phone;
                this.email = data.Email;
                this.bloodGroup = data.BloodGroup ?? 1;
                this.gender = data.Gender ?? 1;
                this.dob = data.DOB.ToString();
            }
        }

        public void InsertAdmin()
        {
            var newAdmin = new Test_AdminTable();
            newAdmin.Name = this.name;
            newAdmin.FatherName = this.father;
            newAdmin.MotherName = this.mother;
            newAdmin.Phone = this.phone;
            newAdmin.Email = this.email;
            newAdmin.BloodGroup = this.bloodGroup;
            newAdmin.Gender = this.gender;
            newAdmin.ID = this.id;
            newAdmin.DOB = Convert.ToDateTime(this.dob);
            newAdmin.Password = this.password;
            AdminDataContext.Test_AdminTables.InsertOnSubmit(newAdmin);
            AdminDataContext.SubmitChanges();
        }

        public IQueryable GetStudentTable()
        {
            return AdminDataContext.Test_StudentTables;
        }

        public string GetName()
        {
            return this.name;
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

        public List<string> GetDepartmentData()
        {
            return AdminDataContext.DepartmentTables.Select(s => s.DepartmentName).ToList();
        }

        public void SetPassword(string value)
        {
            this.password = value;
        }
    }
}
