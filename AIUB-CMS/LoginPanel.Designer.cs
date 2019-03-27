namespace AIUB_CMS
{
    partial class LoginPanel
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
            this.PasswordField = new MetroFramework.Controls.MetroTextBox();
            this.IdField = new MetroFramework.Controls.MetroTextBox();
            this.LoginButton = new MetroFramework.Controls.MetroButton();
            this.RememberPasswordCheckbox = new MaterialSkin.Controls.MaterialCheckBox();
            this.CMSLogo = new System.Windows.Forms.PictureBox();
            this.CMSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CMSLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordField
            // 
            this.PasswordField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.PasswordField.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.PasswordField.Location = new System.Drawing.Point(126, 292);
            this.PasswordField.MaxLength = 20;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '●';
            this.PasswordField.PromptText = "Password";
            this.PasswordField.Size = new System.Drawing.Size(250, 33);
            this.PasswordField.TabIndex = 1;
            this.PasswordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // IdField
            // 
            this.IdField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.IdField.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.IdField.Location = new System.Drawing.Point(126, 246);
            this.IdField.MaxLength = 20;
            this.IdField.Name = "IdField";
            this.IdField.PromptText = "ID";
            this.IdField.Size = new System.Drawing.Size(250, 33);
            this.IdField.TabIndex = 0;
            this.IdField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LoginButton.Location = new System.Drawing.Point(202, 389);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(103, 47);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RememberPasswordCheckbox
            // 
            this.RememberPasswordCheckbox.AutoSize = true;
            this.RememberPasswordCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RememberPasswordCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RememberPasswordCheckbox.Depth = 0;
            this.RememberPasswordCheckbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.RememberPasswordCheckbox.Location = new System.Drawing.Point(169, 345);
            this.RememberPasswordCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.RememberPasswordCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RememberPasswordCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.RememberPasswordCheckbox.Name = "RememberPasswordCheckbox";
            this.RememberPasswordCheckbox.Ripple = true;
            this.RememberPasswordCheckbox.Size = new System.Drawing.Size(160, 30);
            this.RememberPasswordCheckbox.TabIndex = 2;
            this.RememberPasswordCheckbox.Text = "Remember password";
            this.RememberPasswordCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RememberPasswordCheckbox.UseVisualStyleBackColor = true;
            // 
            // CMSLogo
            // 
            this.CMSLogo.Image = global::AIUB_CMS.Properties.Resources.LogoCMS;
            this.CMSLogo.Location = new System.Drawing.Point(179, 44);
            this.CMSLogo.Name = "CMSLogo";
            this.CMSLogo.Size = new System.Drawing.Size(150, 150);
            this.CMSLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CMSLogo.TabIndex = 5;
            this.CMSLogo.TabStop = false;
            // 
            // CMSLabel
            // 
            this.CMSLabel.AutoSize = true;
            this.CMSLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMSLabel.Location = new System.Drawing.Point(109, 206);
            this.CMSLabel.Name = "CMSLabel";
            this.CMSLabel.Size = new System.Drawing.Size(294, 25);
            this.CMSLabel.TabIndex = 6;
            this.CMSLabel.Text = "AIUB-Class-Mangement-System";
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.CMSLabel);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.IdField);
            this.Controls.Add(this.CMSLogo);
            this.Controls.Add(this.RememberPasswordCheckbox);
            this.Controls.Add(this.LoginButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimizeBox = false;
            this.Name = "LoginPanel";
            this.Resizable = false;
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            ((System.ComponentModel.ISupportInitialize)(this.CMSLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox PasswordField;
        private MetroFramework.Controls.MetroTextBox IdField;
        private MetroFramework.Controls.MetroButton LoginButton;
        private MaterialSkin.Controls.MaterialCheckBox RememberPasswordCheckbox;
        private System.Windows.Forms.PictureBox CMSLogo;
        private System.Windows.Forms.Label CMSLabel;
    }
}

