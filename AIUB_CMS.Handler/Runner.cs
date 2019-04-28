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
            LoginFormInitializer.InitializeLoginForm();
            string type = LoginFormInitializer.GetIDType();
            string id = LoginFormInitializer.GetID();

            if (type == "Student")
                StudentFormInitializer.InitializeStudentForm(id);
            else if (type == "Faculty")
                FacultyFormInitializer.InitializeFacultyForm(id);
            else if (type == "Admin")
                AdminFormInitializer.InitializeAdminForm(id);

            //// Sample admin: 1234-12345-2 PASS: admin
            //// Sample faculty: 1234-12345-1 PASS iamironman
        }
    }
}