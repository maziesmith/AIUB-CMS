using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_CMS
{
    class IDValidator
    {
        public IDValidator()
        {
            // Do Nothing.
        }

        public bool validateID(string ID)
        {
            string[] splitID = ID.Split('-');

            if (splitID.Length > 3)
                return false;
            else
            {
                if (splitID[0].Length == 2 || splitID[0].Length == 4)
                    if (splitID[1].Length == 5)
                        if (splitID[2].Length == 1)
                            if (int.Parse(splitID[2]) <= 2 && splitID[0].Length == 4 && int.Parse(splitID[2]) != 0)
                                return true;
                            else if (int.Parse(splitID[2]) <= 3 && splitID[0].Length == 2 && int.Parse(splitID[2]) != 0)
                                return true;
            }

            return false;
        }
    }
}
