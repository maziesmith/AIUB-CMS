using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIUB_CMS.FacultyView.Interface;

namespace AIUB_CMS.FacultyView.Handler
{
    class FacultyFormInitializer
    {
        // Initialize the student form.
        public static void FacultyInitializer()
        {
            Application.Run(new FacultyInterface());
        }
    }
}