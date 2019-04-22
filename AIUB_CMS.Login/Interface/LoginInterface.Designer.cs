namespace AIUB_CMS.Login.Interface
{
    partial class LoginInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginInterface));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.textboxID = new MetroFramework.Controls.MetroTextBox();
            this.textboxPassword = new MetroFramework.Controls.MetroTextBox();
            this.buttonLogin = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(112, 232);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(233, 30);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome to AIUB-CMS";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::AIUB_CMS.Login.Properties.Resources.LogoCMS;
            this.pictureLogo.Location = new System.Drawing.Point(145, 69);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(166, 160);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 2;
            this.pictureLogo.TabStop = false;
            // 
            // textboxID
            // 
            // 
            // 
            // 
            this.textboxID.CustomButton.Image = null;
            this.textboxID.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.textboxID.CustomButton.Name = "";
            this.textboxID.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.textboxID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxID.CustomButton.TabIndex = 1;
            this.textboxID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxID.CustomButton.UseSelectable = true;
            this.textboxID.CustomButton.Visible = false;
            this.textboxID.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.textboxID.Lines = new string[0];
            this.textboxID.Location = new System.Drawing.Point(117, 290);
            this.textboxID.MaxLength = 32767;
            this.textboxID.Name = "textboxID";
            this.textboxID.PasswordChar = '\0';
            this.textboxID.PromptText = "ID";
            this.textboxID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxID.SelectedText = "";
            this.textboxID.SelectionLength = 0;
            this.textboxID.SelectionStart = 0;
            this.textboxID.ShortcutsEnabled = true;
            this.textboxID.Size = new System.Drawing.Size(216, 35);
            this.textboxID.TabIndex = 1;
            this.textboxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxID.UseSelectable = true;
            this.textboxID.WaterMark = "ID";
            this.textboxID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // textboxPassword
            // 
            // 
            // 
            // 
            this.textboxPassword.CustomButton.Image = null;
            this.textboxPassword.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.textboxPassword.CustomButton.Name = "";
            this.textboxPassword.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.textboxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxPassword.CustomButton.TabIndex = 1;
            this.textboxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxPassword.CustomButton.UseSelectable = true;
            this.textboxPassword.CustomButton.Visible = false;
            this.textboxPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.textboxPassword.Lines = new string[0];
            this.textboxPassword.Location = new System.Drawing.Point(117, 331);
            this.textboxPassword.MaxLength = 32767;
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '●';
            this.textboxPassword.PromptText = "Password";
            this.textboxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxPassword.SelectedText = "";
            this.textboxPassword.SelectionLength = 0;
            this.textboxPassword.SelectionStart = 0;
            this.textboxPassword.ShortcutsEnabled = true;
            this.textboxPassword.Size = new System.Drawing.Size(216, 35);
            this.textboxPassword.TabIndex = 2;
            this.textboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxPassword.UseSelectable = true;
            this.textboxPassword.UseSystemPasswordChar = true;
            this.textboxPassword.WaterMark = "Password";
            this.textboxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxPassword_KeyPress);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(176, 401);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(99, 50);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseSelectable = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // LoginInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.textboxID);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.labelWelcome);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "LoginInterface";
            this.Padding = new System.Windows.Forms.Padding(40, 138, 40, 46);
            this.Resizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureLogo;
        private MetroFramework.Controls.MetroTextBox textboxID;
        private MetroFramework.Controls.MetroTextBox textboxPassword;
        private MetroFramework.Controls.MetroButton buttonLogin;
    }
}