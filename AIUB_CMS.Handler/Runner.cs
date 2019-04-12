using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AIUB_CMS.Login.Interface;

namespace AIUB_CMS.Handler
{
    // The Runner class is used to execute the initial login form.
    static class Runner
    {
        static void Main()
        {
            LoginFormInitializer.InitializeLoginForm();
        }
    }
}
