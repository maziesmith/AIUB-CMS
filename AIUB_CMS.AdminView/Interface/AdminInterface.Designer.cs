namespace AIUB_CMS.AdminView.Interface
{
    partial class AdminInterface
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInterface));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlAdmin = new MetroFramework.Controls.MetroTabControl();
            this.tabAdminInfo = new MetroFramework.Controls.MetroTabPage();
            this.tabManageStudent = new MetroFramework.Controls.MetroTabPage();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.labelID = new MetroFramework.Controls.MetroLabel();
            this.labelGender = new MetroFramework.Controls.MetroLabel();
            this.labelBloodGroup = new MetroFramework.Controls.MetroLabel();
            this.labelDepartment = new MetroFramework.Controls.MetroLabel();
            this.labelMother = new MetroFramework.Controls.MetroLabel();
            this.labelPhone = new MetroFramework.Controls.MetroLabel();
            this.labelProgram = new MetroFramework.Controls.MetroLabel();
            this.labelFather = new MetroFramework.Controls.MetroLabel();
            this.labelEmail = new MetroFramework.Controls.MetroLabel();
            this.labelDOB = new MetroFramework.Controls.MetroLabel();
            this.labelName = new MetroFramework.Controls.MetroLabel();
            this.tabStudentDatabase = new MetroFramework.Controls.MetroTabPage();
            this.datagridStudentTable = new MetroFramework.Controls.MetroGrid();
            this.tabCourseDatabase = new MetroFramework.Controls.MetroTabPage();
            this.tabManageFaculty = new MetroFramework.Controls.MetroTabPage();
            this.tabFacultyDatabase = new MetroFramework.Controls.MetroTabPage();
            this.tabManageAdmin = new MetroFramework.Controls.MetroTabPage();
            this.tabAdminDatabase = new MetroFramework.Controls.MetroTabPage();
            this.tabManageCourse = new MetroFramework.Controls.MetroTabPage();
            this.metroTextBox7 = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlAdmin.SuspendLayout();
            this.tabManageStudent.SuspendLayout();
            this.tabStudentDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridStudentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AIUB_CMS.AdminView.Properties.Resources.LogoCMS;
            this.pictureBox1.Location = new System.Drawing.Point(8, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabAdminInfo);
            this.tabControlAdmin.Controls.Add(this.tabManageStudent);
            this.tabControlAdmin.Controls.Add(this.tabStudentDatabase);
            this.tabControlAdmin.Controls.Add(this.tabCourseDatabase);
            this.tabControlAdmin.Controls.Add(this.tabManageFaculty);
            this.tabControlAdmin.Controls.Add(this.tabFacultyDatabase);
            this.tabControlAdmin.Controls.Add(this.tabManageAdmin);
            this.tabControlAdmin.Controls.Add(this.tabAdminDatabase);
            this.tabControlAdmin.Controls.Add(this.tabManageCourse);
            this.tabControlAdmin.Location = new System.Drawing.Point(8, 117);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 1;
            this.tabControlAdmin.Size = new System.Drawing.Size(1184, 499);
            this.tabControlAdmin.TabIndex = 1;
            this.tabControlAdmin.UseSelectable = true;
            // 
            // tabAdminInfo
            // 
            this.tabAdminInfo.HorizontalScrollbarBarColor = true;
            this.tabAdminInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAdminInfo.HorizontalScrollbarSize = 10;
            this.tabAdminInfo.Location = new System.Drawing.Point(4, 38);
            this.tabAdminInfo.Name = "tabAdminInfo";
            this.tabAdminInfo.Size = new System.Drawing.Size(1176, 457);
            this.tabAdminInfo.TabIndex = 0;
            this.tabAdminInfo.Text = "Admin Information";
            this.tabAdminInfo.VerticalScrollbarBarColor = true;
            this.tabAdminInfo.VerticalScrollbarHighlightOnWheel = false;
            this.tabAdminInfo.VerticalScrollbarSize = 10;
            // 
            // tabManageStudent
            // 
            this.tabManageStudent.Controls.Add(this.metroDateTime1);
            this.tabManageStudent.Controls.Add(this.metroComboBox3);
            this.tabManageStudent.Controls.Add(this.metroTextBox6);
            this.tabManageStudent.Controls.Add(this.metroTextBox5);
            this.tabManageStudent.Controls.Add(this.metroTextBox4);
            this.tabManageStudent.Controls.Add(this.metroTextBox3);
            this.tabManageStudent.Controls.Add(this.metroTextBox2);
            this.tabManageStudent.Controls.Add(this.metroTextBox1);
            this.tabManageStudent.Controls.Add(this.metroComboBox2);
            this.tabManageStudent.Controls.Add(this.metroComboBox1);
            this.tabManageStudent.Controls.Add(this.labelID);
            this.tabManageStudent.Controls.Add(this.labelGender);
            this.tabManageStudent.Controls.Add(this.labelBloodGroup);
            this.tabManageStudent.Controls.Add(this.labelDepartment);
            this.tabManageStudent.Controls.Add(this.labelMother);
            this.tabManageStudent.Controls.Add(this.labelPhone);
            this.tabManageStudent.Controls.Add(this.labelProgram);
            this.tabManageStudent.Controls.Add(this.labelFather);
            this.tabManageStudent.Controls.Add(this.labelEmail);
            this.tabManageStudent.Controls.Add(this.labelDOB);
            this.tabManageStudent.Controls.Add(this.labelName);
            this.tabManageStudent.HorizontalScrollbarBarColor = true;
            this.tabManageStudent.HorizontalScrollbarHighlightOnWheel = false;
            this.tabManageStudent.HorizontalScrollbarSize = 10;
            this.tabManageStudent.Location = new System.Drawing.Point(4, 38);
            this.tabManageStudent.Name = "tabManageStudent";
            this.tabManageStudent.Size = new System.Drawing.Size(1176, 457);
            this.tabManageStudent.TabIndex = 1;
            this.tabManageStudent.Text = "Manage Student";
            this.tabManageStudent.VerticalScrollbarBarColor = true;
            this.tabManageStudent.VerticalScrollbarHighlightOnWheel = false;
            this.tabManageStudent.VerticalScrollbarSize = 10;
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Location = new System.Drawing.Point(150, 246);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(81, 29);
            this.metroComboBox3.TabIndex = 48;
            this.metroComboBox3.UseSelectable = true;
            // 
            // metroTextBox6
            // 
            // 
            // 
            // 
            this.metroTextBox6.CustomButton.Image = null;
            this.metroTextBox6.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.metroTextBox6.CustomButton.Name = "";
            this.metroTextBox6.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox6.CustomButton.TabIndex = 1;
            this.metroTextBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox6.CustomButton.UseSelectable = true;
            this.metroTextBox6.CustomButton.Visible = false;
            this.metroTextBox6.Lines = new string[0];
            this.metroTextBox6.Location = new System.Drawing.Point(150, 23);
            this.metroTextBox6.MaxLength = 32767;
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.PasswordChar = '\0';
            this.metroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox6.SelectedText = "";
            this.metroTextBox6.SelectionLength = 0;
            this.metroTextBox6.SelectionStart = 0;
            this.metroTextBox6.ShortcutsEnabled = true;
            this.metroTextBox6.Size = new System.Drawing.Size(200, 23);
            this.metroTextBox6.TabIndex = 47;
            this.metroTextBox6.UseSelectable = true;
            this.metroTextBox6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox5
            // 
            // 
            // 
            // 
            this.metroTextBox5.CustomButton.Image = null;
            this.metroTextBox5.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.metroTextBox5.CustomButton.Name = "";
            this.metroTextBox5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox5.CustomButton.TabIndex = 1;
            this.metroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox5.CustomButton.UseSelectable = true;
            this.metroTextBox5.CustomButton.Visible = false;
            this.metroTextBox5.Lines = new string[0];
            this.metroTextBox5.Location = new System.Drawing.Point(150, 54);
            this.metroTextBox5.MaxLength = 32767;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '\0';
            this.metroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox5.SelectedText = "";
            this.metroTextBox5.SelectionLength = 0;
            this.metroTextBox5.SelectionStart = 0;
            this.metroTextBox5.ShortcutsEnabled = true;
            this.metroTextBox5.Size = new System.Drawing.Size(200, 23);
            this.metroTextBox5.TabIndex = 46;
            this.metroTextBox5.UseSelectable = true;
            this.metroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(150, 86);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(200, 23);
            this.metroTextBox4.TabIndex = 45;
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(150, 117);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(200, 23);
            this.metroTextBox3.TabIndex = 44;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(150, 148);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(200, 23);
            this.metroTextBox2.TabIndex = 43;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(150, 182);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(200, 23);
            this.metroTextBox1.TabIndex = 42;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(150, 345);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox2.TabIndex = 40;
            this.metroComboBox2.UseSelectable = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(150, 380);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 39;
            this.metroComboBox1.UseSelectable = true;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelID.Location = new System.Drawing.Point(11, 54);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 19);
            this.labelID.TabIndex = 27;
            this.labelID.Text = "ID:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelGender.Location = new System.Drawing.Point(11, 281);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(57, 19);
            this.labelGender.TabIndex = 26;
            this.labelGender.Text = "Gender:";
            // 
            // labelBloodGroup
            // 
            this.labelBloodGroup.AutoSize = true;
            this.labelBloodGroup.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelBloodGroup.Location = new System.Drawing.Point(11, 246);
            this.labelBloodGroup.Name = "labelBloodGroup";
            this.labelBloodGroup.Size = new System.Drawing.Size(90, 19);
            this.labelBloodGroup.TabIndex = 25;
            this.labelBloodGroup.Text = "Blood Group:";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelDepartment.Location = new System.Drawing.Point(11, 380);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(86, 19);
            this.labelDepartment.TabIndex = 23;
            this.labelDepartment.Text = "Department:";
            // 
            // labelMother
            // 
            this.labelMother.AutoSize = true;
            this.labelMother.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelMother.Location = new System.Drawing.Point(11, 117);
            this.labelMother.Name = "labelMother";
            this.labelMother.Size = new System.Drawing.Size(104, 19);
            this.labelMother.TabIndex = 22;
            this.labelMother.Text = "Mother\'s Name";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelPhone.Location = new System.Drawing.Point(11, 148);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(51, 19);
            this.labelPhone.TabIndex = 21;
            this.labelPhone.Text = "Phone:";
            // 
            // labelProgram
            // 
            this.labelProgram.AutoSize = true;
            this.labelProgram.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelProgram.Location = new System.Drawing.Point(11, 345);
            this.labelProgram.Name = "labelProgram";
            this.labelProgram.Size = new System.Drawing.Size(65, 19);
            this.labelProgram.TabIndex = 20;
            this.labelProgram.Text = "Program:";
            // 
            // labelFather
            // 
            this.labelFather.AutoSize = true;
            this.labelFather.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelFather.Location = new System.Drawing.Point(11, 86);
            this.labelFather.Name = "labelFather";
            this.labelFather.Size = new System.Drawing.Size(100, 19);
            this.labelFather.TabIndex = 18;
            this.labelFather.Text = "Father\'s Name:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelEmail.Location = new System.Drawing.Point(11, 179);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 19);
            this.labelEmail.TabIndex = 17;
            this.labelEmail.Text = "Email:";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelDOB.Location = new System.Drawing.Point(11, 211);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(41, 19);
            this.labelDOB.TabIndex = 16;
            this.labelDOB.Text = "DOB:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelName.Location = new System.Drawing.Point(11, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 19);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Name: ";
            // 
            // tabStudentDatabase
            // 
            this.tabStudentDatabase.Controls.Add(this.metroTextBox7);
            this.tabStudentDatabase.Controls.Add(this.datagridStudentTable);
            this.tabStudentDatabase.HorizontalScrollbarBarColor = true;
            this.tabStudentDatabase.HorizontalScrollbarHighlightOnWheel = false;
            this.tabStudentDatabase.HorizontalScrollbarSize = 10;
            this.tabStudentDatabase.Location = new System.Drawing.Point(4, 38);
            this.tabStudentDatabase.Name = "tabStudentDatabase";
            this.tabStudentDatabase.Size = new System.Drawing.Size(1176, 457);
            this.tabStudentDatabase.TabIndex = 5;
            this.tabStudentDatabase.Text = "Student Database";
            this.tabStudentDatabase.VerticalScrollbarBarColor = true;
            this.tabStudentDatabase.VerticalScrollbarHighlightOnWheel = false;
            this.tabStudentDatabase.VerticalScrollbarSize = 10;
            // 
            // datagridStudentTable
            // 
            this.datagridStudentTable.AllowUserToAddRows = false;
            this.datagridStudentTable.AllowUserToDeleteRows = false;
            this.datagridStudentTable.AllowUserToResizeRows = false;
            this.datagridStudentTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.datagridStudentTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridStudentTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datagridStudentTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridStudentTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridStudentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridStudentTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridStudentTable.EnableHeadersVisualStyles = false;
            this.datagridStudentTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.datagridStudentTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.datagridStudentTable.Location = new System.Drawing.Point(0, 32);
            this.datagridStudentTable.Name = "datagridStudentTable";
            this.datagridStudentTable.ReadOnly = true;
            this.datagridStudentTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridStudentTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridStudentTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridStudentTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridStudentTable.Size = new System.Drawing.Size(1176, 429);
            this.datagridStudentTable.TabIndex = 2;
            // 
            // tabCourseDatabase
            // 
            this.tabCourseDatabase.HorizontalScrollbarBarColor = true;
            this.tabCourseDatabase.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCourseDatabase.HorizontalScrollbarSize = 10;
            this.tabCourseDatabase.Location = new System.Drawing.Point(4, 38);
            this.tabCourseDatabase.Name = "tabCourseDatabase";
            this.tabCourseDatabase.Size = new System.Drawing.Size(1176, 457);
            this.tabCourseDatabase.TabIndex = 8;
            this.tabCourseDatabase.Text = "Course Database";
            this.tabCourseDatabase.VerticalScrollbarBarColor = true;
            this.tabCourseDatabase.VerticalScrollbarHighlightOnWheel = false;
            this.tabCourseDatabase.VerticalScrollbarSize = 10;
            // 
            // tabManageFaculty
            // 
            this.tabManageFaculty.HorizontalScrollbarBarColor = true;
            this.tabManageFaculty.HorizontalScrollbarHighlightOnWheel = false;
            this.tabManageFaculty.HorizontalScrollbarSize = 10;
            this.tabManageFaculty.Location = new System.Drawing.Point(4, 38);
            this.tabManageFaculty.Name = "tabManageFaculty";
            this.tabManageFaculty.Size = new System.Drawing.Size(1176, 457);
            this.tabManageFaculty.TabIndex = 2;
            this.tabManageFaculty.Text = "Manage Faculty";
            this.tabManageFaculty.VerticalScrollbarBarColor = true;
            this.tabManageFaculty.VerticalScrollbarHighlightOnWheel = false;
            this.tabManageFaculty.VerticalScrollbarSize = 10;
            // 
            // tabFacultyDatabase
            // 
            this.tabFacultyDatabase.HorizontalScrollbarBarColor = true;
            this.tabFacultyDatabase.HorizontalScrollbarHighlightOnWheel = false;
            this.tabFacultyDatabase.HorizontalScrollbarSize = 10;
            this.tabFacultyDatabase.Location = new System.Drawing.Point(4, 38);
            this.tabFacultyDatabase.Name = "tabFacultyDatabase";
            this.tabFacultyDatabase.Size = new System.Drawing.Size(1176, 457);
            this.tabFacultyDatabase.TabIndex = 6;
            this.tabFacultyDatabase.Text = "Faculty Database";
            this.tabFacultyDatabase.VerticalScrollbarBarColor = true;
            this.tabFacultyDatabase.VerticalScrollbarHighlightOnWheel = false;
            this.tabFacultyDatabase.VerticalScrollbarSize = 10;
            // 
            // tabManageAdmin
            // 
            this.tabManageAdmin.HorizontalScrollbarBarColor = true;
            this.tabManageAdmin.HorizontalScrollbarHighlightOnWheel = false;
            this.tabManageAdmin.HorizontalScrollbarSize = 10;
            this.tabManageAdmin.Location = new System.Drawing.Point(4, 38);
            this.tabManageAdmin.Name = "tabManageAdmin";
            this.tabManageAdmin.Size = new System.Drawing.Size(1176, 457);
            this.tabManageAdmin.TabIndex = 3;
            this.tabManageAdmin.Text = "Manage Admin";
            this.tabManageAdmin.VerticalScrollbarBarColor = true;
            this.tabManageAdmin.VerticalScrollbarHighlightOnWheel = false;
            this.tabManageAdmin.VerticalScrollbarSize = 10;
            // 
            // tabAdminDatabase
            // 
            this.tabAdminDatabase.HorizontalScrollbarBarColor = true;
            this.tabAdminDatabase.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAdminDatabase.HorizontalScrollbarSize = 10;
            this.tabAdminDatabase.Location = new System.Drawing.Point(4, 38);
            this.tabAdminDatabase.Name = "tabAdminDatabase";
            this.tabAdminDatabase.Size = new System.Drawing.Size(1176, 457);
            this.tabAdminDatabase.TabIndex = 7;
            this.tabAdminDatabase.Text = "Admin Database";
            this.tabAdminDatabase.VerticalScrollbarBarColor = true;
            this.tabAdminDatabase.VerticalScrollbarHighlightOnWheel = false;
            this.tabAdminDatabase.VerticalScrollbarSize = 10;
            // 
            // tabManageCourse
            // 
            this.tabManageCourse.HorizontalScrollbarBarColor = true;
            this.tabManageCourse.HorizontalScrollbarHighlightOnWheel = false;
            this.tabManageCourse.HorizontalScrollbarSize = 10;
            this.tabManageCourse.Location = new System.Drawing.Point(4, 38);
            this.tabManageCourse.Name = "tabManageCourse";
            this.tabManageCourse.Size = new System.Drawing.Size(1176, 457);
            this.tabManageCourse.TabIndex = 4;
            this.tabManageCourse.Text = "Manage Course";
            this.tabManageCourse.VerticalScrollbarBarColor = true;
            this.tabManageCourse.VerticalScrollbarHighlightOnWheel = false;
            this.tabManageCourse.VerticalScrollbarSize = 10;
            // 
            // metroTextBox7
            // 
            // 
            // 
            // 
            this.metroTextBox7.CustomButton.Image = null;
            this.metroTextBox7.CustomButton.Location = new System.Drawing.Point(482, 1);
            this.metroTextBox7.CustomButton.Name = "";
            this.metroTextBox7.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox7.CustomButton.TabIndex = 1;
            this.metroTextBox7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox7.CustomButton.UseSelectable = true;
            this.metroTextBox7.CustomButton.Visible = false;
            this.metroTextBox7.Lines = new string[] {
        "metroTextBox7"};
            this.metroTextBox7.Location = new System.Drawing.Point(0, 3);
            this.metroTextBox7.MaxLength = 32767;
            this.metroTextBox7.Name = "metroTextBox7";
            this.metroTextBox7.PasswordChar = '\0';
            this.metroTextBox7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox7.SelectedText = "";
            this.metroTextBox7.SelectionLength = 0;
            this.metroTextBox7.SelectionStart = 0;
            this.metroTextBox7.ShortcutsEnabled = true;
            this.metroTextBox7.Size = new System.Drawing.Size(504, 23);
            this.metroTextBox7.TabIndex = 2;
            this.metroTextBox7.Text = "metroTextBox7";
            this.metroTextBox7.UseSelectable = true;
            this.metroTextBox7.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox7.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(150, 211);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 49;
            // 
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.tabControlAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminInterface";
            this.Resizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlAdmin.ResumeLayout(false);
            this.tabManageStudent.ResumeLayout(false);
            this.tabManageStudent.PerformLayout();
            this.tabStudentDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridStudentTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabControl tabControlAdmin;
        private MetroFramework.Controls.MetroTabPage tabAdminInfo;
        private MetroFramework.Controls.MetroTabPage tabManageStudent;
        private MetroFramework.Controls.MetroTabPage tabManageFaculty;
        private MetroFramework.Controls.MetroTabPage tabManageAdmin;
        private MetroFramework.Controls.MetroTabPage tabManageCourse;
        private MetroFramework.Controls.MetroTabPage tabStudentDatabase;
        private MetroFramework.Controls.MetroTabPage tabFacultyDatabase;
        private MetroFramework.Controls.MetroTabPage tabAdminDatabase;
        private MetroFramework.Controls.MetroTabPage tabCourseDatabase;
        private MetroFramework.Controls.MetroLabel labelGender;
        private MetroFramework.Controls.MetroLabel labelBloodGroup;
        private MetroFramework.Controls.MetroLabel labelDepartment;
        private MetroFramework.Controls.MetroLabel labelMother;
        private MetroFramework.Controls.MetroLabel labelPhone;
        private MetroFramework.Controls.MetroLabel labelProgram;
        private MetroFramework.Controls.MetroLabel labelFather;
        private MetroFramework.Controls.MetroLabel labelEmail;
        private MetroFramework.Controls.MetroLabel labelDOB;
        private MetroFramework.Controls.MetroLabel labelName;
        private MetroFramework.Controls.MetroLabel labelID;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroGrid datagridStudentTable;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox7;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
    }
}