using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_CMS.FacultyView.Data
{
    class AttendanceDataHandler
    {
        FacultyDataDataContext AttendanceDataContext;
        public AttendanceDataHandler()
        {
            this.AttendanceDataContext = new FacultyDataDataContext();
        }

        public List<string> GetStudentMACs()
        {
            var MACs = from student in AttendanceDataContext.Test_AttendanceTables
                       select student.StudentMAC;
            return MACs.ToList();
        }

        public void GiveAttendance(int ClassNumber, string StudentMAC)
        {
            switch (ClassNumber)
            {
                case 1:
                    AttendanceDataContext.Test_AttendanceTables.SingleOrDefault(s => s.StudentMAC == StudentMAC).Class1 = "Present";
                    break;

                case 2:
                    AttendanceDataContext.Test_AttendanceTables.SingleOrDefault(s => s.StudentMAC == StudentMAC).Class2 = "Present";
                    break;

                case 3:
                    AttendanceDataContext.Test_AttendanceTables.SingleOrDefault(s => s.StudentMAC == StudentMAC).Class3 = "Present";
                    break;

                case 4:
                    AttendanceDataContext.Test_AttendanceTables.SingleOrDefault(s => s.StudentMAC == StudentMAC).Class4 = "Present";
                    break;

                case 5:
                    AttendanceDataContext.Test_AttendanceTables.SingleOrDefault(s => s.StudentMAC == StudentMAC).Class5 = "Present";
                    break;

                case 6:
                    AttendanceDataContext.Test_AttendanceTables.SingleOrDefault(s => s.StudentMAC == StudentMAC).Class6 = "Present";
                    break;

                case 7:
                    AttendanceDataContext.Test_AttendanceTables.SingleOrDefault(s => s.StudentMAC == StudentMAC).Class7 = "Present";
                    break;

                case 8:
                    AttendanceDataContext.Test_AttendanceTables.SingleOrDefault(s => s.StudentMAC == StudentMAC).Class8 = "Present";
                    break;
            }
            Console.WriteLine(StudentMAC);
            AttendanceDataContext.SubmitChanges();
        }
    }
}
