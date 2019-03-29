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

        public bool Validate(string id)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            var dtm = dc.Mapping;

            foreach (var t in dtm.GetTables())
            {
                Console.WriteLine(t.TableName);
            }

            var query =
                from a in dc.LoginTests
                where a.ID.Equals(id)
                select a.HashedPassword;


            string pass = "";

            foreach (var student in query)
            {
                pass = student;
            }

            // Console.WriteLine(query);

            string hash = CalculateMD5Hash(password);

            if (hash.Equals(pass))
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
