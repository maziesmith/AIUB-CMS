using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIUB_CMS.AdminView.Data;

namespace AIUB_CMS.AdminView.Interface
{
    public partial class AdminInterface : MetroFramework.Forms.MetroForm
    {
        public AdminInterface()
        {
            InitializeComponent();

            AdminDataHandler AdminData = new AdminDataHandler();

            datagridStudentTable.DataSource = AdminData.GetStudentTables();
        }
    }
}
