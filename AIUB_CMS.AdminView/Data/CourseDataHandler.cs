using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_CMS.AdminView.Data
{
    class CourseDataHandler
    {
        private string name;
        private int id;
        private int department;
        private int credits;
        private int section;
        private int daySlot;
        private int startTime;
        private int endTime;

        AdminDataDataContext CourseDataContext;

        public CourseDataHandler()
        {
            this.CourseDataContext = new AdminDataDataContext();
        }

        public CourseDataHandler(int id)
        {
            this.id = id;
            this.CourseDataContext = new AdminDataDataContext();
            var CourseInformation = from course in CourseDataContext.Test_CourseTables
                                     where course.ID == id
                                     select course;
            CourseInformation.ToList();
            foreach (var data in CourseInformation)
            {
                this.name = data.Name;
                this.id = data.ID;
                this.department = data.Department ?? 1;
                this.credits = data.Credits ?? 1;
                this.section = data.Section ?? 1;
                this.daySlot = data.DaySlot ?? 1;
                this.startTime = data.StartTime ?? 1;
                this.endTime = data.EndTime ?? 1;
            }
        }

        public void InsertCourse()
        {
            var newCourse = new Test_CourseTable();
            // newCourse.ID = this.id;
            newCourse.Name = this.name;
            newCourse.Department = this.department;
            newCourse.Credits = this.credits;
            newCourse.Section = this.section;
            newCourse.DaySlot = this.daySlot;
            newCourse.StartTime = this.startTime;
            newCourse.EndTime = this.endTime;
            CourseDataContext.Test_CourseTables.InsertOnSubmit(newCourse);
            CourseDataContext.SubmitChanges();
        }

        public void UpdateCourse()
        {
            var newCourse = CourseDataContext.Test_CourseTables.SingleOrDefault(c => c.ID == id);
            // newCourse.ID = this.id;
            newCourse.Name = this.name;
            newCourse.Department = this.department;
            newCourse.Credits = this.credits;
            newCourse.Section = this.section;
            newCourse.DaySlot = this.daySlot;
            newCourse.StartTime = this.startTime;
            newCourse.EndTime = this.endTime;
            CourseDataContext.SubmitChanges();
        }

        public void DeleteCourse()
        {
            var newCourse = CourseDataContext.Test_CourseTables.SingleOrDefault(c => c.ID == id);
            CourseDataContext.Test_CourseTables.DeleteOnSubmit(newCourse);
            CourseDataContext.SubmitChanges();
        }

        public IQueryable GetFacultyCoursesAssigned(string facultyName)
        {
            var coursesAssigned = from courses in CourseDataContext.Test_CourseAssignments
                                  where courses.FacultyID == CourseDataContext.Test_FacultyTables.SingleOrDefault(f => f.Name == facultyName).ID
                                  select new { CourseID = courses.CourseID };
            return coursesAssigned;
        }

        public IQueryable SearchCourseByName(string name)
        {
            var ByName = from table in CourseDataContext.Test_CourseTables
                         where table.Name.Contains(name)
                         select table;
            return ByName;
        }

        public IQueryable SearchCourseByID(int id)
        {
            var ByID = from table in CourseDataContext.Test_CourseTables
                         where table.ID == id
                         select table;
            return ByID;
        }

        public IQueryable SearchAssignCourseByName(string name)
        {
            var ByName = from table in CourseDataContext.Test_CourseTables
                         where table.Name.Contains(name)
                         select new { Name = table.Name, Section = table.Section };
            return ByName;
        }

        public IQueryable SearchAssignCourseByID(int id)
        {
            var ByID = from table in CourseDataContext.Test_CourseTables
                       where table.ID == id
                       select new { Name = table.Name, Section = table.Section };
            return ByID;
        }

        public IQueryable GetAssignCourseTable()
        {
            var UnassignedCourses = from course in CourseDataContext.Test_CourseTables
                                    select new { Name = course.Name, Section = course.Section };
            return UnassignedCourses;
        }

        public IQueryable GetCourseTable()
        {
            return CourseDataContext.Test_CourseTables;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetCredits()
        {
            return this.credits;
        }

        public int GetDepartment()
        {
            return this.department;
        }

        public int GetID()
        {
            return this.id;
        }

        public int GetSection()
        {
            return this.section;
        }

        public int GetDaySlot()
        {
            return this.daySlot;
        }

        public int GetStartTime()
        {
            return this.startTime;
        }

        public int GetEndTime()
        {
            return this.endTime;
        }

        public void SetName(string value)
        {
            this.name = value;
        }

        public void SetCredits(int value)
        {
            this.credits = value;
        }

        public void SetDepartment(int value)
        {
            this.department = value;
        }

        public void SetID(int value)
        {
            this.id = value;
        }

        public void SetSection(int value)
        {
            this.section = value;
        }

        public void SetDaySlot(int value)
        {
            this.daySlot = value;
        }

        public void SetStartTime(int value)
        {
            this.startTime = value;
        }

        public void SetEndTime(int value)
        {
            this.endTime = value;
        }
    }
}
