using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace AIUB_CMS.FacultyView.Logic
{
    class MacParser
    {
        public List<string> ParseForMacAddress(string fileAddress)
        {
            string rawArpList = File.ReadAllText("C:\\Users\\Saqibur Rahman\\Desktop\\AIUB-CMS\\TestingData\\studentList.txt");
            List<string> parsed = showMatch(rawArpList, @"\w\w-\w\w-\w\w-\w\w");
            Console.WriteLine(parsed);
            return parsed;
        }

        public List<string> showMatch(string raw, string expression)
        {
            List<string> parsed = new List<string>();
            MatchCollection matchCollection = Regex.Matches(raw, expression);
            foreach (Match m in matchCollection)
            {
                parsed.Add(m.ToString());
            }

            return parsed;
        }
    }
}
