using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIUB_CMS.FacultyView.Interface;

namespace AIUB_CMS.FacultyView.Handler
{
    public static class FacultyFormInitializer
    {
        // Initialize the Faculty form.
        public static void InitializeFacultyForm()
        {
            Application.Run(new FacultyInterface());
        }
    }
}