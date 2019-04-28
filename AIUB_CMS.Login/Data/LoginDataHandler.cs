﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace AIUB_CMS.Login.Data
{
    class LoginDataHandler
    {
        private LoginDataDataContext loginData;
        public LoginDataHandler()
        {
            this.loginData = new LoginDataDataContext();
        }

        public string GetPassword(string id)
        {
            
            // To print the hashed password, uncomment the line below.
            // Console.WriteLine(PasswordTable.FirstOrDefault(s => s.ID == id).Password);
            try
            {
                var password = loginData.Test_StudentTables;
                return password.FirstOrDefault(s => s.ID == id).Password;
            }
            catch
            {
                try
                {
                    var password = loginData.Test_FacultyTables;
                    return password.FirstOrDefault(s => s.ID == id).Password;
                }
                catch
                {
                    try
                    {
                        var password = loginData.Test_AdminTables;
                        return password.FirstOrDefault(s => s.ID == id).Password;
                    }
                    catch
                    {
                        return "null";
                    }
                }
            }
            
        }
    }
}
