using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIUB_CMS.Login.Logic;

namespace AIUB_CMS.Login.Interface
{
    public partial class LoginInterface : MetroFramework.Forms.MetroForm
    {
        public LoginInterface()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            IDValidation validator = new IDValidation();
            if (validator.ValidateID(this.textboxID.Text))
            {
                MessageBox.Show("Valid ID.");
                ID id = new ID(textboxID.Text);
                id.ParseID();
                MessageBox.Show(id.GetIdType() + "");

                PasswordValidation password = new PasswordValidation(textboxPassword.Text);

                if (password.Validate(textboxID.Text))
                {
                    MessageBox.Show("Valid password.");
                    LoginFormInitializer.SetID(id.GetFullID());
                    LoginFormInitializer.SetIDType(id.GetIdType());
                    this.Close();
                } 
                else
                    MessageBox.Show("Invalid password.");


            }
            else
            {
                MessageBox.Show("Invalid ID.");
            }
        }

        private void textboxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                buttonLogin_Click(sender, e);
            }
        }
    }
}
