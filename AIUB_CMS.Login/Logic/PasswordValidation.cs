using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using AIUB_CMS.Login.Data;

namespace AIUB_CMS.Login.Logic
{
    class PasswordValidation
    {
        private string password;

        public PasswordValidation()
        {
            // Do nothing.
        }

        public PasswordValidation(string password)
        {
            this.password = CalculateMD5Hash(password);
        }

        public bool Validate(string id)
        {
            LoginDataHandler loginDataHandler = new LoginDataHandler();
            string passwordFromDatabase = loginDataHandler.GetPassword(id);

            if (passwordFromDatabase == password)
                return true;
            else
                return false;
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
