using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.GData.Calendar;

namespace AIUB_CMS.StudentView.Interface
{
    public partial class StudentInterface : MetroFramework.Forms.MetroForm
    {
        string name;
        string id;
        string CGPA;
        string credit;
        string program;
        string department;
        string core;
        string father;
        string mother;
        string phone;
        string email;

        public StudentInterface()
        {
            // Do nothing.
        }

        public StudentInterface(string id)
        {
            InitializeComponent();
            


        }

        private GetStudentInfo(string id)
        {

        }
    }
}
