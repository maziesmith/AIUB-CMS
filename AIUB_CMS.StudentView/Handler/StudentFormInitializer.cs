using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIUB_CMS.StudentView.Interface;

namespace AIUB_CMS.StudentView.Handler
{
    public static class StudentFormInitializer
    {
        // Initialize the student form.
        public static void InitializeStudentForm(string id)
        {
            Application.Run(new StudentInterface(id));
        }
    }
}
