using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;

namespace AIUB_CMS
{
    class PasswordValidator
    {
        private string password;

        public PasswordValidator()
        {
            // Do nothing.
        }

        public PasswordValidator(string password)
        {
            this.password = password;
        }

        public bool Validate()
        {
            LoginTest lt = new LoginTest();

            
            string hash = CalculateMD5Hash(password);
            Console.WriteLine(hash);
            return true;

            
        }

        public string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
