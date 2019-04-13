using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_CMS.AdminView.Data
{
    class AdminDataHandler
    {
        public IQueryable GetStudentTables()
        {
            StudentDataDataContext StudentData = new StudentDataDataContext();
            return StudentData.Test_StudentTables;
        }
    }
}
