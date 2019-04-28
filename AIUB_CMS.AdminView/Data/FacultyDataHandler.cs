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
        private int department;
        private string father;
        private string mother;
        private string phone;
        private string email;
        private int gender;
        private int bloodGroup;
        private DateTime dob;
        private int nationality;
        private string password;

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
                this.dob = data.DOB?? DateTime.Now;
                this.nationality = data.Nationality?? 1;

            }
        }

        public void InsertFaculty()
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
            newFaculty.DOB = this.dob;
            newFaculty.Nationality = this.nationality;
            newFaculty.Password = this.password;
            FacultyDataContext.Test_FacultyTables.InsertOnSubmit(newFaculty);
            FacultyDataContext.SubmitChanges();
        }

        public void UpdateFaculty()
        {
            var newFaculty = FacultyDataContext.Test_FacultyTables.SingleOrDefault(f => f.ID == id);
            newFaculty.Name = this.name;
            newFaculty.Department = this.department;
            newFaculty.FatherName = this.father;
            newFaculty.MotherName = this.mother;
            newFaculty.PhoneNumber = this.phone;
            newFaculty.Email = this.email;
            newFaculty.BloodGroup = this.bloodGroup;
            newFaculty.Gender = this.gender;
            newFaculty.ID = this.id;
            newFaculty.DOB = this.dob;
            newFaculty.Nationality = this.nationality;
            newFaculty.Password = this.password;
            FacultyDataContext.SubmitChanges();
        }

        public void DeleteFaculty()
        {
            var newFaculty = FacultyDataContext.Test_FacultyTables.SingleOrDefault(f => f.ID == id);
            FacultyDataContext.Test_FacultyTables.DeleteOnSubmit(newFaculty);
            FacultyDataContext.SubmitChanges();
        }

        public IQueryable GetFacultyTable()
        {
            return FacultyDataContext.Test_FacultyTables;
        }

        public IQueryable SearchFacultyByID(string id)
        {
            var ByID = from table in FacultyDataContext.Test_FacultyTables
                       where table.ID.Contains(id)
                       select table;
            return ByID;
        }

        public IQueryable SearchFacultyByName(string name)
        {
            var ByName = from table in FacultyDataContext.Test_FacultyTables
                         where table.Name.Contains(name)
                         select table;
            return ByName;
        }

        public void SetNationality(int value)
        {
            this.nationality = value;
        }

        public int GetNationality()
        {
            return nationality;
        }

        public string GetName()
        {
            return this.name;
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

        public DateTime GetDOB()
        {
            return this.dob;
        }

        public void SetName(string value)
        {
            this.name = value;
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

        public void SetDOB(DateTime value)
        {
            this.dob = value;
        }

        public void SetPassword(string value)
        {
            this.password = value;
        }
    }
}
