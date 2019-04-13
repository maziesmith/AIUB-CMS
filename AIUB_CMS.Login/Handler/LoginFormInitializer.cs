using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIUB_CMS.Login.Interface
{
    public static class LoginFormInitializer
    {
        // Initialize the login form.
        private static string id;
        public static void InitializeLoginForm()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginInterface());
        }

        public static void SetID(string ID)
        {
            id = ID;
        }

        public static string GetID()
        {
            return id;
        }
    }
}
