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
            this.datetimeDOB = new MetroFramework.Controls.MetroDateTime();
            this.comboboxBloodGroup = new MetroFramework.Controls.MetroComboBox();
            this.textboxName = new MetroFramework.Controls.MetroTextBox();
            this.textboxID = new MetroFramework.Controls.MetroTextBox();
            this.textboxFather = new MetroFramework.Controls.MetroTextBox();
            this.textboxMother = new MetroFramework.Controls.MetroTextBox();
            this.textboxPhone = new MetroFramework.Controls.MetroTextBox();
            this.textboxEmail = new MetroFramework.Controls.MetroTextBox();
            this.comboboxProgram = new MetroFramework.Controls.MetroComboBox();
            this.comboboxDepartment = new MetroFramework.Controls.MetroComboBox();
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
            this.groupboxPersonalInformation = new System.Windows.Forms.GroupBox();
            this.groupboxAcademicInformation = new System.Windows.Forms.GroupBox();
            this.grouboxGender = new System.Windows.Forms.GroupBox();
            this.radiobuttonMale = new MetroFramework.Controls.MetroRadioButton();
            this.radiobuttonFemale = new MetroFramework.Controls.MetroRadioButton();
            this.buttonUpdateStudent = new MetroFramework.Controls.MetroButton();
            this.labelCreditsCompleted = new MetroFramework.Controls.MetroLabel();
            this.textboxCreditsCompleted = new MetroFramework.Controls.MetroTextBox();
            this.buttonDeleteStudent = new MetroFramework.Controls.MetroButton();
            this.buttonCreateStudent = new MetroFramework.Controls.MetroButton();
            this.labelMAC = new MetroFramework.Controls.MetroLabel();
            this.textboxMAC = new MetroFramework.Controls.MetroTextBox();
            this.labelCGPA = new MetroFramework.Controls.MetroLabel();
            this.textboxCGPA = new MetroFramework.Controls.MetroTextBox();
            this.buttonGetStudent = new MetroFramework.Controls.MetroButton();
            this.labelNationality = new MetroFramework.Controls.MetroLabel();
            this.comboboxNationality = new MetroFramework.Controls.MetroComboBox();
            this.labelPassword = new MetroFramework.Controls.MetroLabel();
            this.textboxPassword = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonUpdateImage = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlAdmin.SuspendLayout();
            this.tabManageStudent.SuspendLayout();
            this.tabStudentDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridStudentTable)).BeginInit();
            this.groupboxPersonalInformation.SuspendLayout();
            this.groupboxAcademicInformation.SuspendLayout();
            this.grouboxGender.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.tabManageStudent.Controls.Add(this.groupBox1);
            this.tabManageStudent.Controls.Add(this.buttonGetStudent);
            this.tabManageStudent.Controls.Add(this.buttonCreateStudent);
            this.tabManageStudent.Controls.Add(this.buttonDeleteStudent);
            this.tabManageStudent.Controls.Add(this.buttonUpdateStudent);
            this.tabManageStudent.Controls.Add(this.groupboxAcademicInformation);
            this.tabManageStudent.Controls.Add(this.groupboxPersonalInformation);
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
            // datetimeDOB
            // 
            this.datetimeDOB.Location = new System.Drawing.Point(159, 212);
            this.datetimeDOB.MinimumSize = new System.Drawing.Size(0, 29);
            this.datetimeDOB.Name = "datetimeDOB";
            this.datetimeDOB.Size = new System.Drawing.Size(200, 29);
            this.datetimeDOB.TabIndex = 49;
            // 
            // comboboxBloodGroup
            // 
            this.comboboxBloodGroup.FormattingEnabled = true;
            this.comboboxBloodGroup.ItemHeight = 23;
            this.comboboxBloodGroup.Location = new System.Drawing.Point(159, 287);
            this.comboboxBloodGroup.Name = "comboboxBloodGroup";
            this.comboboxBloodGroup.Size = new System.Drawing.Size(81, 29);
            this.comboboxBloodGroup.TabIndex = 48;
            this.comboboxBloodGroup.UseSelectable = true;
            // 
            // textboxName
            // 
            // 
            // 
            // 
            this.textboxName.CustomButton.Image = null;
            this.textboxName.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.textboxName.CustomButton.Name = "";
            this.textboxName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxName.CustomButton.TabIndex = 1;
            this.textboxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxName.CustomButton.UseSelectable = true;
            this.textboxName.CustomButton.Visible = false;
            this.textboxName.Lines = new string[0];
            this.textboxName.Location = new System.Drawing.Point(159, 24);
            this.textboxName.MaxLength = 32767;
            this.textboxName.Name = "textboxName";
            this.textboxName.PasswordChar = '\0';
            this.textboxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxName.SelectedText = "";
            this.textboxName.SelectionLength = 0;
            this.textboxName.SelectionStart = 0;
            this.textboxName.ShortcutsEnabled = true;
            this.textboxName.Size = new System.Drawing.Size(200, 23);
            this.textboxName.TabIndex = 47;
            this.textboxName.UseSelectable = true;
            this.textboxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textboxID
            // 
            // 
            // 
            // 
            this.textboxID.CustomButton.Image = null;
            this.textboxID.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.textboxID.CustomButton.Name = "";
            this.textboxID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxID.CustomButton.TabIndex = 1;
            this.textboxID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxID.CustomButton.UseSelectable = true;
            this.textboxID.CustomButton.Visible = false;
            this.textboxID.Lines = new string[0];
            this.textboxID.Location = new System.Drawing.Point(159, 55);
            this.textboxID.MaxLength = 32767;
            this.textboxID.Name = "textboxID";
            this.textboxID.PasswordChar = '\0';
            this.textboxID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxID.SelectedText = "";
            this.textboxID.SelectionLength = 0;
            this.textboxID.SelectionStart = 0;
            this.textboxID.ShortcutsEnabled = true;
            this.textboxID.Size = new System.Drawing.Size(200, 23);
            this.textboxID.TabIndex = 46;
            this.textboxID.UseSelectable = true;
            this.textboxID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textboxFather
            // 
            // 
            // 
            // 
            this.textboxFather.CustomButton.Image = null;
            this.textboxFather.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.textboxFather.CustomButton.Name = "";
            this.textboxFather.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxFather.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxFather.CustomButton.TabIndex = 1;
            this.textboxFather.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxFather.CustomButton.UseSelectable = true;
            this.textboxFather.CustomButton.Visible = false;
            this.textboxFather.Lines = new string[0];
            this.textboxFather.Location = new System.Drawing.Point(159, 87);
            this.textboxFather.MaxLength = 32767;
            this.textboxFather.Name = "textboxFather";
            this.textboxFather.PasswordChar = '\0';
            this.textboxFather.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxFather.SelectedText = "";
            this.textboxFather.SelectionLength = 0;
            this.textboxFather.SelectionStart = 0;
            this.textboxFather.ShortcutsEnabled = true;
            this.textboxFather.Size = new System.Drawing.Size(200, 23);
            this.textboxFather.TabIndex = 45;
            this.textboxFather.UseSelectable = true;
            this.textboxFather.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxFather.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textboxMother
            // 
            // 
            // 
            // 
            this.textboxMother.CustomButton.Image = null;
            this.textboxMother.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.textboxMother.CustomButton.Name = "";
            this.textboxMother.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxMother.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxMother.CustomButton.TabIndex = 1;
            this.textboxMother.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxMother.CustomButton.UseSelectable = true;
            this.textboxMother.CustomButton.Visible = false;
            this.textboxMother.Lines = new string[0];
            this.textboxMother.Location = new System.Drawing.Point(159, 118);
            this.textboxMother.MaxLength = 32767;
            this.textboxMother.Name = "textboxMother";
            this.textboxMother.PasswordChar = '\0';
            this.textboxMother.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxMother.SelectedText = "";
            this.textboxMother.SelectionLength = 0;
            this.textboxMother.SelectionStart = 0;
            this.textboxMother.ShortcutsEnabled = true;
            this.textboxMother.Size = new System.Drawing.Size(200, 23);
            this.textboxMother.TabIndex = 44;
            this.textboxMother.UseSelectable = true;
            this.textboxMother.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxMother.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textboxPhone
            // 
            // 
            // 
            // 
            this.textboxPhone.CustomButton.Image = null;
            this.textboxPhone.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.textboxPhone.CustomButton.Name = "";
            this.textboxPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxPhone.CustomButton.TabIndex = 1;
            this.textboxPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxPhone.CustomButton.UseSelectable = true;
            this.textboxPhone.CustomButton.Visible = false;
            this.textboxPhone.Lines = new string[0];
            this.textboxPhone.Location = new System.Drawing.Point(159, 149);
            this.textboxPhone.MaxLength = 32767;
            this.textboxPhone.Name = "textboxPhone";
            this.textboxPhone.PasswordChar = '\0';
            this.textboxPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxPhone.SelectedText = "";
            this.textboxPhone.SelectionLength = 0;
            this.textboxPhone.SelectionStart = 0;
            this.textboxPhone.ShortcutsEnabled = true;
            this.textboxPhone.Size = new System.Drawing.Size(200, 23);
            this.textboxPhone.TabIndex = 43;
            this.textboxPhone.UseSelectable = true;
            this.textboxPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textboxEmail
            // 
            // 
            // 
            // 
            this.textboxEmail.CustomButton.Image = null;
            this.textboxEmail.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.textboxEmail.CustomButton.Name = "";
            this.textboxEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxEmail.CustomButton.TabIndex = 1;
            this.textboxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxEmail.CustomButton.UseSelectable = true;
            this.textboxEmail.CustomButton.Visible = false;
            this.textboxEmail.Lines = new string[0];
            this.textboxEmail.Location = new System.Drawing.Point(159, 183);
            this.textboxEmail.MaxLength = 32767;
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.PasswordChar = '\0';
            this.textboxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxEmail.SelectedText = "";
            this.textboxEmail.SelectionLength = 0;
            this.textboxEmail.SelectionStart = 0;
            this.textboxEmail.ShortcutsEnabled = true;
            this.textboxEmail.Size = new System.Drawing.Size(200, 23);
            this.textboxEmail.TabIndex = 42;
            this.textboxEmail.UseSelectable = true;
            this.textboxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboboxProgram
            // 
            this.comboboxProgram.FormattingEnabled = true;
            this.comboboxProgram.ItemHeight = 23;
            this.comboboxProgram.Location = new System.Drawing.Point(160, 118);
            this.comboboxProgram.Name = "comboboxProgram";
            this.comboboxProgram.Size = new System.Drawing.Size(121, 29);
            this.comboboxProgram.TabIndex = 40;
            this.comboboxProgram.UseSelectable = true;
            // 
            // comboboxDepartment
            // 
            this.comboboxDepartment.FormattingEnabled = true;
            this.comboboxDepartment.ItemHeight = 23;
            this.comboboxDepartment.Location = new System.Drawing.Point(160, 153);
            this.comboboxDepartment.Name = "comboboxDepartment";
            this.comboboxDepartment.Size = new System.Drawing.Size(121, 29);
            this.comboboxDepartment.TabIndex = 39;
            this.comboboxDepartment.UseSelectable = true;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelID.Location = new System.Drawing.Point(20, 55);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 19);
            this.labelID.TabIndex = 27;
            this.labelID.Text = "ID:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelGender.Location = new System.Drawing.Point(20, 339);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(57, 19);
            this.labelGender.TabIndex = 26;
            this.labelGender.Text = "Gender:";
            // 
            // labelBloodGroup
            // 
            this.labelBloodGroup.AutoSize = true;
            this.labelBloodGroup.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelBloodGroup.Location = new System.Drawing.Point(20, 287);
            this.labelBloodGroup.Name = "labelBloodGroup";
            this.labelBloodGroup.Size = new System.Drawing.Size(90, 19);
            this.labelBloodGroup.TabIndex = 25;
            this.labelBloodGroup.Text = "Blood Group:";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelDepartment.Location = new System.Drawing.Point(21, 153);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(86, 19);
            this.labelDepartment.TabIndex = 23;
            this.labelDepartment.Text = "Department:";
            // 
            // labelMother
            // 
            this.labelMother.AutoSize = true;
            this.labelMother.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelMother.Location = new System.Drawing.Point(20, 118);
            this.labelMother.Name = "labelMother";
            this.labelMother.Size = new System.Drawing.Size(104, 19);
            this.labelMother.TabIndex = 22;
            this.labelMother.Text = "Mother\'s Name";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelPhone.Location = new System.Drawing.Point(20, 149);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(51, 19);
            this.labelPhone.TabIndex = 21;
            this.labelPhone.Text = "Phone:";
            // 
            // labelProgram
            // 
            this.labelProgram.AutoSize = true;
            this.labelProgram.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelProgram.Location = new System.Drawing.Point(21, 118);
            this.labelProgram.Name = "labelProgram";
            this.labelProgram.Size = new System.Drawing.Size(65, 19);
            this.labelProgram.TabIndex = 20;
            this.labelProgram.Text = "Program:";
            // 
            // labelFather
            // 
            this.labelFather.AutoSize = true;
            this.labelFather.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelFather.Location = new System.Drawing.Point(20, 87);
            this.labelFather.Name = "labelFather";
            this.labelFather.Size = new System.Drawing.Size(100, 19);
            this.labelFather.TabIndex = 18;
            this.labelFather.Text = "Father\'s Name:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelEmail.Location = new System.Drawing.Point(20, 180);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 19);
            this.labelEmail.TabIndex = 17;
            this.labelEmail.Text = "Email:";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelDOB.Location = new System.Drawing.Point(20, 212);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(41, 19);
            this.labelDOB.TabIndex = 16;
            this.labelDOB.Text = "DOB:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelName.Location = new System.Drawing.Point(20, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 19);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Name: ";
            // 
            // tabStudentDatabase
            // 
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
            // groupboxPersonalInformation
            // 
            this.groupboxPersonalInformation.BackColor = System.Drawing.Color.Transparent;
            this.groupboxPersonalInformation.Controls.Add(this.comboboxNationality);
            this.groupboxPersonalInformation.Controls.Add(this.labelNationality);
            this.groupboxPersonalInformation.Controls.Add(this.grouboxGender);
            this.groupboxPersonalInformation.Controls.Add(this.labelName);
            this.groupboxPersonalInformation.Controls.Add(this.labelDOB);
            this.groupboxPersonalInformation.Controls.Add(this.labelEmail);
            this.groupboxPersonalInformation.Controls.Add(this.datetimeDOB);
            this.groupboxPersonalInformation.Controls.Add(this.labelFather);
            this.groupboxPersonalInformation.Controls.Add(this.comboboxBloodGroup);
            this.groupboxPersonalInformation.Controls.Add(this.textboxName);
            this.groupboxPersonalInformation.Controls.Add(this.labelPhone);
            this.groupboxPersonalInformation.Controls.Add(this.textboxID);
            this.groupboxPersonalInformation.Controls.Add(this.labelMother);
            this.groupboxPersonalInformation.Controls.Add(this.textboxFather);
            this.groupboxPersonalInformation.Controls.Add(this.textboxMother);
            this.groupboxPersonalInformation.Controls.Add(this.labelBloodGroup);
            this.groupboxPersonalInformation.Controls.Add(this.textboxPhone);
            this.groupboxPersonalInformation.Controls.Add(this.labelGender);
            this.groupboxPersonalInformation.Controls.Add(this.textboxEmail);
            this.groupboxPersonalInformation.Controls.Add(this.labelID);
            this.groupboxPersonalInformation.Location = new System.Drawing.Point(8, 19);
            this.groupboxPersonalInformation.Name = "groupboxPersonalInformation";
            this.groupboxPersonalInformation.Size = new System.Drawing.Size(367, 423);
            this.groupboxPersonalInformation.TabIndex = 50;
            this.groupboxPersonalInformation.TabStop = false;
            this.groupboxPersonalInformation.Text = "Personal Information";
            // 
            // groupboxAcademicInformation
            // 
            this.groupboxAcademicInformation.BackColor = System.Drawing.Color.Transparent;
            this.groupboxAcademicInformation.Controls.Add(this.textboxPassword);
            this.groupboxAcademicInformation.Controls.Add(this.labelPassword);
            this.groupboxAcademicInformation.Controls.Add(this.textboxCGPA);
            this.groupboxAcademicInformation.Controls.Add(this.labelCGPA);
            this.groupboxAcademicInformation.Controls.Add(this.textboxMAC);
            this.groupboxAcademicInformation.Controls.Add(this.labelMAC);
            this.groupboxAcademicInformation.Controls.Add(this.labelCreditsCompleted);
            this.groupboxAcademicInformation.Controls.Add(this.labelProgram);
            this.groupboxAcademicInformation.Controls.Add(this.textboxCreditsCompleted);
            this.groupboxAcademicInformation.Controls.Add(this.comboboxProgram);
            this.groupboxAcademicInformation.Controls.Add(this.comboboxDepartment);
            this.groupboxAcademicInformation.Controls.Add(this.labelDepartment);
            this.groupboxAcademicInformation.Location = new System.Drawing.Point(400, 19);
            this.groupboxAcademicInformation.Name = "groupboxAcademicInformation";
            this.groupboxAcademicInformation.Size = new System.Drawing.Size(372, 231);
            this.groupboxAcademicInformation.TabIndex = 51;
            this.groupboxAcademicInformation.TabStop = false;
            this.groupboxAcademicInformation.Text = "Academic Information";
            // 
            // grouboxGender
            // 
            this.grouboxGender.BackColor = System.Drawing.Color.Transparent;
            this.grouboxGender.Controls.Add(this.radiobuttonFemale);
            this.grouboxGender.Controls.Add(this.radiobuttonMale);
            this.grouboxGender.Location = new System.Drawing.Point(159, 322);
            this.grouboxGender.Name = "grouboxGender";
            this.grouboxGender.Size = new System.Drawing.Size(172, 54);
            this.grouboxGender.TabIndex = 52;
            this.grouboxGender.TabStop = false;
            // 
            // radiobuttonMale
            // 
            this.radiobuttonMale.AutoSize = true;
            this.radiobuttonMale.Location = new System.Drawing.Point(23, 22);
            this.radiobuttonMale.Name = "radiobuttonMale";
            this.radiobuttonMale.Size = new System.Drawing.Size(49, 15);
            this.radiobuttonMale.TabIndex = 52;
            this.radiobuttonMale.Text = "Male";
            this.radiobuttonMale.UseSelectable = true;
            // 
            // radiobuttonFemale
            // 
            this.radiobuttonFemale.AutoSize = true;
            this.radiobuttonFemale.Location = new System.Drawing.Point(91, 22);
            this.radiobuttonFemale.Name = "radiobuttonFemale";
            this.radiobuttonFemale.Size = new System.Drawing.Size(61, 15);
            this.radiobuttonFemale.TabIndex = 53;
            this.radiobuttonFemale.Text = "Female";
            this.radiobuttonFemale.UseSelectable = true;
            // 
            // buttonUpdateStudent
            // 
            this.buttonUpdateStudent.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonUpdateStudent.Highlight = true;
            this.buttonUpdateStudent.Location = new System.Drawing.Point(445, 376);
            this.buttonUpdateStudent.Name = "buttonUpdateStudent";
            this.buttonUpdateStudent.Size = new System.Drawing.Size(132, 46);
            this.buttonUpdateStudent.TabIndex = 54;
            this.buttonUpdateStudent.Text = "Update Student";
            this.buttonUpdateStudent.UseSelectable = true;
            // 
            // labelCreditsCompleted
            // 
            this.labelCreditsCompleted.AutoSize = true;
            this.labelCreditsCompleted.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelCreditsCompleted.Location = new System.Drawing.Point(21, 24);
            this.labelCreditsCompleted.Name = "labelCreditsCompleted";
            this.labelCreditsCompleted.Size = new System.Drawing.Size(126, 19);
            this.labelCreditsCompleted.TabIndex = 53;
            this.labelCreditsCompleted.Text = "Credits Completed:";
            // 
            // textboxCreditsCompleted
            // 
            // 
            // 
            // 
            this.textboxCreditsCompleted.CustomButton.Image = null;
            this.textboxCreditsCompleted.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.textboxCreditsCompleted.CustomButton.Name = "";
            this.textboxCreditsCompleted.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxCreditsCompleted.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxCreditsCompleted.CustomButton.TabIndex = 1;
            this.textboxCreditsCompleted.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxCreditsCompleted.CustomButton.UseSelectable = true;
            this.textboxCreditsCompleted.CustomButton.Visible = false;
            this.textboxCreditsCompleted.Lines = new string[0];
            this.textboxCreditsCompleted.Location = new System.Drawing.Point(160, 24);
            this.textboxCreditsCompleted.MaxLength = 32767;
            this.textboxCreditsCompleted.Name = "textboxCreditsCompleted";
            this.textboxCreditsCompleted.PasswordChar = '\0';
            this.textboxCreditsCompleted.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxCreditsCompleted.SelectedText = "";
            this.textboxCreditsCompleted.SelectionLength = 0;
            this.textboxCreditsCompleted.SelectionStart = 0;
            this.textboxCreditsCompleted.ShortcutsEnabled = true;
            this.textboxCreditsCompleted.Size = new System.Drawing.Size(201, 23);
            this.textboxCreditsCompleted.TabIndex = 54;
            this.textboxCreditsCompleted.UseSelectable = true;
            this.textboxCreditsCompleted.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxCreditsCompleted.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonDeleteStudent.Highlight = true;
            this.buttonDeleteStudent.Location = new System.Drawing.Point(605, 376);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(132, 46);
            this.buttonDeleteStudent.TabIndex = 55;
            this.buttonDeleteStudent.Text = "Delete Student";
            this.buttonDeleteStudent.UseSelectable = true;
            // 
            // buttonCreateStudent
            // 
            this.buttonCreateStudent.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonCreateStudent.Highlight = true;
            this.buttonCreateStudent.Location = new System.Drawing.Point(605, 306);
            this.buttonCreateStudent.Name = "buttonCreateStudent";
            this.buttonCreateStudent.Size = new System.Drawing.Size(132, 46);
            this.buttonCreateStudent.TabIndex = 56;
            this.buttonCreateStudent.Text = "Create Student";
            this.buttonCreateStudent.UseSelectable = true;
            this.buttonCreateStudent.Click += new System.EventHandler(this.buttonCreateStudent_Click);
            // 
            // labelMAC
            // 
            this.labelMAC.AutoSize = true;
            this.labelMAC.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelMAC.Location = new System.Drawing.Point(21, 87);
            this.labelMAC.Name = "labelMAC";
            this.labelMAC.Size = new System.Drawing.Size(96, 19);
            this.labelMAC.TabIndex = 55;
            this.labelMAC.Text = "MAC Address:";
            // 
            // textboxMAC
            // 
            // 
            // 
            // 
            this.textboxMAC.CustomButton.Image = null;
            this.textboxMAC.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.textboxMAC.CustomButton.Name = "";
            this.textboxMAC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxMAC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxMAC.CustomButton.TabIndex = 1;
            this.textboxMAC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxMAC.CustomButton.UseSelectable = true;
            this.textboxMAC.CustomButton.Visible = false;
            this.textboxMAC.Lines = new string[0];
            this.textboxMAC.Location = new System.Drawing.Point(160, 87);
            this.textboxMAC.MaxLength = 32767;
            this.textboxMAC.Name = "textboxMAC";
            this.textboxMAC.PasswordChar = '\0';
            this.textboxMAC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxMAC.SelectedText = "";
            this.textboxMAC.SelectionLength = 0;
            this.textboxMAC.SelectionStart = 0;
            this.textboxMAC.ShortcutsEnabled = true;
            this.textboxMAC.Size = new System.Drawing.Size(201, 23);
            this.textboxMAC.TabIndex = 56;
            this.textboxMAC.UseSelectable = true;
            this.textboxMAC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxMAC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelCGPA
            // 
            this.labelCGPA.AutoSize = true;
            this.labelCGPA.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelCGPA.Location = new System.Drawing.Point(21, 55);
            this.labelCGPA.Name = "labelCGPA";
            this.labelCGPA.Size = new System.Drawing.Size(47, 19);
            this.labelCGPA.TabIndex = 57;
            this.labelCGPA.Text = "CGPA:";
            // 
            // textboxCGPA
            // 
            // 
            // 
            // 
            this.textboxCGPA.CustomButton.Image = null;
            this.textboxCGPA.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.textboxCGPA.CustomButton.Name = "";
            this.textboxCGPA.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxCGPA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxCGPA.CustomButton.TabIndex = 1;
            this.textboxCGPA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxCGPA.CustomButton.UseSelectable = true;
            this.textboxCGPA.CustomButton.Visible = false;
            this.textboxCGPA.Lines = new string[0];
            this.textboxCGPA.Location = new System.Drawing.Point(160, 55);
            this.textboxCGPA.MaxLength = 32767;
            this.textboxCGPA.Name = "textboxCGPA";
            this.textboxCGPA.PasswordChar = '\0';
            this.textboxCGPA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxCGPA.SelectedText = "";
            this.textboxCGPA.SelectionLength = 0;
            this.textboxCGPA.SelectionStart = 0;
            this.textboxCGPA.ShortcutsEnabled = true;
            this.textboxCGPA.Size = new System.Drawing.Size(201, 23);
            this.textboxCGPA.TabIndex = 58;
            this.textboxCGPA.UseSelectable = true;
            this.textboxCGPA.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxCGPA.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonGetStudent
            // 
            this.buttonGetStudent.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonGetStudent.Highlight = true;
            this.buttonGetStudent.Location = new System.Drawing.Point(445, 306);
            this.buttonGetStudent.Name = "buttonGetStudent";
            this.buttonGetStudent.Size = new System.Drawing.Size(132, 46);
            this.buttonGetStudent.TabIndex = 57;
            this.buttonGetStudent.Text = "Get Student";
            this.buttonGetStudent.UseSelectable = true;
            this.buttonGetStudent.Click += new System.EventHandler(this.buttonGetStudent_Click);
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelNationality.Location = new System.Drawing.Point(20, 249);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(75, 19);
            this.labelNationality.TabIndex = 53;
            this.labelNationality.Text = "Nationality";
            // 
            // comboboxNationality
            // 
            this.comboboxNationality.FormattingEnabled = true;
            this.comboboxNationality.ItemHeight = 23;
            this.comboboxNationality.Location = new System.Drawing.Point(159, 249);
            this.comboboxNationality.Name = "comboboxNationality";
            this.comboboxNationality.Size = new System.Drawing.Size(200, 29);
            this.comboboxNationality.TabIndex = 54;
            this.comboboxNationality.UseSelectable = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelPassword.Location = new System.Drawing.Point(21, 188);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(96, 19);
            this.labelPassword.TabIndex = 59;
            this.labelPassword.Text = "MAC Address:";
            // 
            // textboxPassword
            // 
            // 
            // 
            // 
            this.textboxPassword.CustomButton.Image = null;
            this.textboxPassword.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.textboxPassword.CustomButton.Name = "";
            this.textboxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxPassword.CustomButton.TabIndex = 1;
            this.textboxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxPassword.CustomButton.UseSelectable = true;
            this.textboxPassword.CustomButton.Visible = false;
            this.textboxPassword.Lines = new string[0];
            this.textboxPassword.Location = new System.Drawing.Point(160, 188);
            this.textboxPassword.MaxLength = 32767;
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '\0';
            this.textboxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxPassword.SelectedText = "";
            this.textboxPassword.SelectionLength = 0;
            this.textboxPassword.SelectionStart = 0;
            this.textboxPassword.ShortcutsEnabled = true;
            this.textboxPassword.Size = new System.Drawing.Size(201, 23);
            this.textboxPassword.TabIndex = 60;
            this.textboxPassword.UseSelectable = true;
            this.textboxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonUpdateImage);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(798, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 333);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Image";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(78, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 207);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // buttonUpdateImage
            // 
            this.buttonUpdateImage.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonUpdateImage.Highlight = true;
            this.buttonUpdateImage.Location = new System.Drawing.Point(117, 260);
            this.buttonUpdateImage.Name = "buttonUpdateImage";
            this.buttonUpdateImage.Size = new System.Drawing.Size(132, 46);
            this.buttonUpdateImage.TabIndex = 57;
            this.buttonUpdateImage.Text = "Update Image";
            this.buttonUpdateImage.UseSelectable = true;
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
            this.tabStudentDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridStudentTable)).EndInit();
            this.groupboxPersonalInformation.ResumeLayout(false);
            this.groupboxPersonalInformation.PerformLayout();
            this.groupboxAcademicInformation.ResumeLayout(false);
            this.groupboxAcademicInformation.PerformLayout();
            this.grouboxGender.ResumeLayout(false);
            this.grouboxGender.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private MetroFramework.Controls.MetroComboBox comboboxProgram;
        private MetroFramework.Controls.MetroComboBox comboboxDepartment;
        private MetroFramework.Controls.MetroGrid datagridStudentTable;
        private MetroFramework.Controls.MetroComboBox comboboxBloodGroup;
        private MetroFramework.Controls.MetroTextBox textboxName;
        private MetroFramework.Controls.MetroTextBox textboxID;
        private MetroFramework.Controls.MetroTextBox textboxFather;
        private MetroFramework.Controls.MetroTextBox textboxMother;
        private MetroFramework.Controls.MetroTextBox textboxPhone;
        private MetroFramework.Controls.MetroTextBox textboxEmail;
        private MetroFramework.Controls.MetroDateTime datetimeDOB;
        private System.Windows.Forms.GroupBox groupboxAcademicInformation;
        private System.Windows.Forms.GroupBox groupboxPersonalInformation;
        private MetroFramework.Controls.MetroRadioButton radiobuttonMale;
        private System.Windows.Forms.GroupBox grouboxGender;
        private MetroFramework.Controls.MetroRadioButton radiobuttonFemale;
        private MetroFramework.Controls.MetroButton buttonUpdateStudent;
        private MetroFramework.Controls.MetroButton buttonGetStudent;
        private MetroFramework.Controls.MetroButton buttonCreateStudent;
        private MetroFramework.Controls.MetroButton buttonDeleteStudent;
        private MetroFramework.Controls.MetroTextBox textboxPassword;
        private MetroFramework.Controls.MetroLabel labelPassword;
        private MetroFramework.Controls.MetroTextBox textboxCGPA;
        private MetroFramework.Controls.MetroLabel labelCGPA;
        private MetroFramework.Controls.MetroTextBox textboxMAC;
        private MetroFramework.Controls.MetroLabel labelMAC;
        private MetroFramework.Controls.MetroLabel labelCreditsCompleted;
        private MetroFramework.Controls.MetroTextBox textboxCreditsCompleted;
        private MetroFramework.Controls.MetroComboBox comboboxNationality;
        private MetroFramework.Controls.MetroLabel labelNationality;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton buttonUpdateImage;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}