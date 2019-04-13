using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIUB_CMS.AdminView.Interface;

namespace AIUB_CMS.AdminView.Handler
{
    public static class AdminFormInitializer
    {
        // Initialize the student form.
        public static void InitializeAdminForm()
        {
            Application.Run(new AdminInterface());
        }
    }
}
