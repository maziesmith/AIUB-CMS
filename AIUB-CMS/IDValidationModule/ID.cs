using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_CMS
{
    class ID
    {
        private string firstPart;
        private string secondPart;
        private string thirdPart;
        private string fullId;

        private string idType;
        private string semester;

        public ID()
        {
            // Do nothing.
        }

        public ID(string id)
        {
            fullId = id;
            string[] splitID = id.Split('-');

            firstPart = splitID[0];
            secondPart = splitID[1];
            thirdPart = splitID[2];
            this.ParseID();
        }

        public void ParseID()
        {
            if (firstPart.Length == 4 && int.Parse(thirdPart) == 1)
            {
                idType = "Faculty";
                semester = "N/A";
            }
            else if (firstPart.Length == 4 && int.Parse(thirdPart) == 2)
            {
                idType = "Admin";
                semester = "N/A";
            }
            else if (firstPart.Length == 2)
            {
                idType = "Student";
                switch (int.Parse(thirdPart))
                {
                    case 1:
                        semester = "Spring";
                        break;
                    case 2:
                        semester = "Summer";
                        break;
                    case 3:
                        semester = "Fall";
                        break;
                }
            }
        }

        public string GetIdType()
        {
            return this.idType;
        }

        public string GetSemester()
        {
            return this.semester;
        }
    }
}
