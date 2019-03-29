using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace AIUB_CMS
{
    public partial class LoginPanel : MetroFramework.Forms.MetroForm
    {
        public LoginPanel()
        {
            InitializeComponent();
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            IDValidator validator = new IDValidator();
            if (validator.ValidateID(this.IdField.Text))
            {
                MessageBox.Show("Valid ID.");
                ID id = new ID(IdField.Text);
                id.ParseID();
                MessageBox.Show(id.GetIdType() + "");

                PasswordValidator password = new PasswordValidator(PasswordField.Text);

                if (password.Validate(IdField.Text))
                    MessageBox.Show("Valid password.");
                else
                    MessageBox.Show("Invalid password.");


            }
            else
            {
                MessageBox.Show("Invalid ID.");
            }
            
        }

    }
}
