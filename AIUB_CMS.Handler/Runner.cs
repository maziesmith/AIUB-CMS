using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AIUB_CMS.Login.Interface;
using AIUB_CMS.StudentView.Handler;
using AIUB_CMS.AdminView.Handler;
using AIUB_CMS.FacultyView.Handler;

namespace AIUB_CMS.Handler
{
    // The Runner class is used to execute the initial login form.
    static class Runner
    {
        [STAThread]
        static void Main()
        {
            // LoginFormInitializer.InitializeLoginForm();
            // StudentFormInitializer.InitializeStudentForm(LoginFormInitializer.GetID());
            AdminFormInitializer.InitializeAdminForm();
            // FacultyFormInitializer.InitializeFacultyForm();
        }
    }
}
