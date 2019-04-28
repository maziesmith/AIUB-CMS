using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_CMS.FacultyView.Data
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

        FacultyDataDataContext CourseDataContext;

        public CourseDataHandler()
        {
            this.CourseDataContext = new FacultyDataDataContext();
        }

        public CourseDataHandler(int id)
        {
            this.id = id;
            this.CourseDataContext = new FacultyDataDataContext();
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
