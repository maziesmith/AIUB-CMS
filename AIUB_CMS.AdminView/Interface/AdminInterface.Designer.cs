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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInterface));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlAdmin = new MetroFramework.Controls.MetroTabControl();
            this.tabAdminInfo = new MetroFramework.Controls.MetroTabPage();
            this.tabManageStudent = new MetroFramework.Controls.MetroTabPage();
            this.tabManageFaculty = new MetroFramework.Controls.MetroTabPage();
            this.tabManageAdmin = new MetroFramework.Controls.MetroTabPage();
            this.tabManageCourse = new MetroFramework.Controls.MetroTabPage();
            this.tabStudentDatabase = new MetroFramework.Controls.MetroTabPage();
            this.tabFacultyDatabase = new MetroFramework.Controls.MetroTabPage();
            this.tabAdminDatabase = new MetroFramework.Controls.MetroTabPage();
            this.tabCourseDatabase = new MetroFramework.Controls.MetroTabPage();
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
            this.labelID = new MetroFramework.Controls.MetroLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textboxFather = new System.Windows.Forms.TextBox();
            this.textboxMother = new System.Windows.Forms.TextBox();
            this.textboxPhone = new System.Windows.Forms.TextBox();
            this.textboxEmail = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.comboboxBloodGroup = new System.Windows.Forms.ComboBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonMale = new MetroFramework.Controls.MetroRadioButton();
            this.radioButtonFemale = new MetroFramework.Controls.MetroRadioButton();
            this.comboboxDepartment = new System.Windows.Forms.ComboBox();
            this.comboboxProgram = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlAdmin.SuspendLayout();
            this.tabManageStudent.SuspendLayout();
            this.tabStudentDatabase.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabControlAdmin.Controls.Add(this.tabManageFaculty);
            this.tabControlAdmin.Controls.Add(this.tabFacultyDatabase);
            this.tabControlAdmin.Controls.Add(this.tabManageAdmin);
            this.tabControlAdmin.Controls.Add(this.tabAdminDatabase);
            this.tabControlAdmin.Controls.Add(this.tabManageCourse);
            this.tabControlAdmin.Controls.Add(this.tabCourseDatabase);
            this.tabControlAdmin.Location = new System.Drawing.Point(8, 117);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 2;
            this.tabControlAdmin.Size = new System.Drawing.Size(1184, 499);
            this.tabControlAdmin.TabIndex = 1;
            // 
            // tabAdminInfo
            // 
            this.tabAdminInfo.HorizontalScrollbarBarColor = true;
            this.tabAdminInfo.Location = new System.Drawing.Point(4, 35);
            this.tabAdminInfo.Name = "tabAdminInfo";
            this.tabAdminInfo.Size = new System.Drawing.Size(1176, 460);
            this.tabAdminInfo.TabIndex = 0;
            this.tabAdminInfo.Text = "Admin Information";
            this.tabAdminInfo.VerticalScrollbarBarColor = true;
            // 
            // tabManageStudent
            // 
            this.tabManageStudent.Controls.Add(this.comboboxProgram);
            this.tabManageStudent.Controls.Add(this.comboboxDepartment);
            this.tabManageStudent.Controls.Add(this.groupBoxGender);
            this.tabManageStudent.Controls.Add(this.comboboxBloodGroup);
            this.tabManageStudent.Controls.Add(this.dateTimePickerDOB);
            this.tabManageStudent.Controls.Add(this.textboxEmail);
            this.tabManageStudent.Controls.Add(this.textboxPhone);
            this.tabManageStudent.Controls.Add(this.textboxMother);
            this.tabManageStudent.Controls.Add(this.textboxFather);
            this.tabManageStudent.Controls.Add(this.textBox2);
            this.tabManageStudent.Controls.Add(this.textBox1);
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
            this.tabManageStudent.Location = new System.Drawing.Point(4, 35);
            this.tabManageStudent.Name = "tabManageStudent";
            this.tabManageStudent.Size = new System.Drawing.Size(1176, 460);
            this.tabManageStudent.TabIndex = 1;
            this.tabManageStudent.Text = "Manage Student";
            this.tabManageStudent.VerticalScrollbarBarColor = true;
            // 
            // tabManageFaculty
            // 
            this.tabManageFaculty.HorizontalScrollbarBarColor = true;
            this.tabManageFaculty.Location = new System.Drawing.Point(4, 35);
            this.tabManageFaculty.Name = "tabManageFaculty";
            this.tabManageFaculty.Size = new System.Drawing.Size(1176, 460);
            this.tabManageFaculty.TabIndex = 2;
            this.tabManageFaculty.Text = "Manage Faculty";
            this.tabManageFaculty.VerticalScrollbarBarColor = true;
            // 
            // tabManageAdmin
            // 
            this.tabManageAdmin.HorizontalScrollbarBarColor = true;
            this.tabManageAdmin.Location = new System.Drawing.Point(4, 35);
            this.tabManageAdmin.Name = "tabManageAdmin";
            this.tabManageAdmin.Size = new System.Drawing.Size(1176, 460);
            this.tabManageAdmin.TabIndex = 3;
            this.tabManageAdmin.Text = "Manage Admin";
            this.tabManageAdmin.VerticalScrollbarBarColor = true;
            // 
            // tabManageCourse
            // 
            this.tabManageCourse.HorizontalScrollbarBarColor = true;
            this.tabManageCourse.Location = new System.Drawing.Point(4, 35);
            this.tabManageCourse.Name = "tabManageCourse";
            this.tabManageCourse.Size = new System.Drawing.Size(1176, 460);
            this.tabManageCourse.TabIndex = 4;
            this.tabManageCourse.Text = "Manage Course";
            this.tabManageCourse.VerticalScrollbarBarColor = true;
            // 
            // tabStudentDatabase
            // 
            this.tabStudentDatabase.Controls.Add(this.dataGridView1);
            this.tabStudentDatabase.HorizontalScrollbarBarColor = true;
            this.tabStudentDatabase.Location = new System.Drawing.Point(4, 35);
            this.tabStudentDatabase.Name = "tabStudentDatabase";
            this.tabStudentDatabase.Size = new System.Drawing.Size(1176, 460);
            this.tabStudentDatabase.TabIndex = 5;
            this.tabStudentDatabase.Text = "Student Database";
            this.tabStudentDatabase.VerticalScrollbarBarColor = true;
            // 
            // tabFacultyDatabase
            // 
            this.tabFacultyDatabase.HorizontalScrollbarBarColor = true;
            this.tabFacultyDatabase.Location = new System.Drawing.Point(4, 35);
            this.tabFacultyDatabase.Name = "tabFacultyDatabase";
            this.tabFacultyDatabase.Size = new System.Drawing.Size(1176, 460);
            this.tabFacultyDatabase.TabIndex = 6;
            this.tabFacultyDatabase.Text = "Faculty Database";
            this.tabFacultyDatabase.VerticalScrollbarBarColor = true;
            // 
            // tabAdminDatabase
            // 
            this.tabAdminDatabase.HorizontalScrollbarBarColor = true;
            this.tabAdminDatabase.Location = new System.Drawing.Point(4, 35);
            this.tabAdminDatabase.Name = "tabAdminDatabase";
            this.tabAdminDatabase.Size = new System.Drawing.Size(1176, 460);
            this.tabAdminDatabase.TabIndex = 7;
            this.tabAdminDatabase.Text = "Admin Database";
            this.tabAdminDatabase.VerticalScrollbarBarColor = true;
            // 
            // tabCourseDatabase
            // 
            this.tabCourseDatabase.HorizontalScrollbarBarColor = true;
            this.tabCourseDatabase.Location = new System.Drawing.Point(4, 35);
            this.tabCourseDatabase.Name = "tabCourseDatabase";
            this.tabCourseDatabase.Size = new System.Drawing.Size(1176, 460);
            this.tabCourseDatabase.TabIndex = 8;
            this.tabCourseDatabase.Text = "Course Database";
            this.tabCourseDatabase.VerticalScrollbarBarColor = true;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelGender.Location = new System.Drawing.Point(11, 349);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(57, 19);
            this.labelGender.TabIndex = 26;
            this.labelGender.Text = "Gender:";
            // 
            // labelBloodGroup
            // 
            this.labelBloodGroup.AutoSize = true;
            this.labelBloodGroup.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelBloodGroup.Location = new System.Drawing.Point(11, 315);
            this.labelBloodGroup.Name = "labelBloodGroup";
            this.labelBloodGroup.Size = new System.Drawing.Size(90, 19);
            this.labelBloodGroup.TabIndex = 25;
            this.labelBloodGroup.Text = "Blood Group:";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelDepartment.Location = new System.Drawing.Point(11, 121);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(86, 19);
            this.labelDepartment.TabIndex = 23;
            this.labelDepartment.Text = "Department:";
            // 
            // labelMother
            // 
            this.labelMother.AutoSize = true;
            this.labelMother.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelMother.Location = new System.Drawing.Point(11, 186);
            this.labelMother.Name = "labelMother";
            this.labelMother.Size = new System.Drawing.Size(104, 19);
            this.labelMother.TabIndex = 22;
            this.labelMother.Text = "Mother\'s Name";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelPhone.Location = new System.Drawing.Point(11, 218);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(51, 19);
            this.labelPhone.TabIndex = 21;
            this.labelPhone.Text = "Phone:";
            // 
            // labelProgram
            // 
            this.labelProgram.AutoSize = true;
            this.labelProgram.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelProgram.Location = new System.Drawing.Point(11, 90);
            this.labelProgram.Name = "labelProgram";
            this.labelProgram.Size = new System.Drawing.Size(65, 19);
            this.labelProgram.TabIndex = 20;
            this.labelProgram.Text = "Program:";
            // 
            // labelFather
            // 
            this.labelFather.AutoSize = true;
            this.labelFather.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelFather.Location = new System.Drawing.Point(11, 152);
            this.labelFather.Name = "labelFather";
            this.labelFather.Size = new System.Drawing.Size(100, 19);
            this.labelFather.TabIndex = 18;
            this.labelFather.Text = "Father\'s Name:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelEmail.Location = new System.Drawing.Point(11, 249);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 19);
            this.labelEmail.TabIndex = 17;
            this.labelEmail.Text = "Email:";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelDOB.Location = new System.Drawing.Point(11, 280);
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
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelID.Location = new System.Drawing.Point(11, 55);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 19);
            this.labelID.TabIndex = 27;
            this.labelID.Text = "ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 29;
            // 
            // textboxFather
            // 
            this.textboxFather.Location = new System.Drawing.Point(150, 152);
            this.textboxFather.Name = "textboxFather";
            this.textboxFather.Size = new System.Drawing.Size(200, 20);
            this.textboxFather.TabIndex = 32;
            // 
            // textboxMother
            // 
            this.textboxMother.Location = new System.Drawing.Point(150, 186);
            this.textboxMother.Name = "textboxMother";
            this.textboxMother.Size = new System.Drawing.Size(200, 20);
            this.textboxMother.TabIndex = 33;
            // 
            // textboxPhone
            // 
            this.textboxPhone.Location = new System.Drawing.Point(150, 218);
            this.textboxPhone.Name = "textboxPhone";
            this.textboxPhone.Size = new System.Drawing.Size(200, 20);
            this.textboxPhone.TabIndex = 34;
            // 
            // textboxEmail
            // 
            this.textboxEmail.Location = new System.Drawing.Point(150, 249);
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.Size = new System.Drawing.Size(200, 20);
            this.textboxEmail.TabIndex = 35;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(150, 280);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDOB.TabIndex = 36;
            // 
            // comboboxBloodGroup
            // 
            this.comboboxBloodGroup.FormattingEnabled = true;
            this.comboboxBloodGroup.Location = new System.Drawing.Point(150, 315);
            this.comboboxBloodGroup.Name = "comboboxBloodGroup";
            this.comboboxBloodGroup.Size = new System.Drawing.Size(200, 21);
            this.comboboxBloodGroup.TabIndex = 37;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Location = new System.Drawing.Point(150, 349);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(200, 53);
            this.groupBoxGender.TabIndex = 38;
            this.groupBoxGender.TabStop = false;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(31, 19);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(49, 15);
            this.radioButtonMale.TabIndex = 39;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(106, 19);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(61, 15);
            this.radioButtonFemale.TabIndex = 40;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // comboboxDepartment
            // 
            this.comboboxDepartment.FormattingEnabled = true;
            this.comboboxDepartment.Location = new System.Drawing.Point(150, 120);
            this.comboboxDepartment.Name = "comboboxDepartment";
            this.comboboxDepartment.Size = new System.Drawing.Size(200, 21);
            this.comboboxDepartment.TabIndex = 39;
            // 
            // comboboxProgram
            // 
            this.comboboxProgram.FormattingEnabled = true;
            this.comboboxProgram.Location = new System.Drawing.Point(150, 88);
            this.comboboxProgram.Name = "comboboxProgram";
            this.comboboxProgram.Size = new System.Drawing.Size(200, 21);
            this.comboboxProgram.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 460);
            this.dataGridView1.TabIndex = 2;
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
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboboxProgram;
        private System.Windows.Forms.ComboBox comboboxDepartment;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private MetroFramework.Controls.MetroRadioButton radioButtonMale;
        private MetroFramework.Controls.MetroRadioButton radioButtonFemale;
        private System.Windows.Forms.ComboBox comboboxBloodGroup;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.TextBox textboxEmail;
        private System.Windows.Forms.TextBox textboxPhone;
        private System.Windows.Forms.TextBox textboxMother;
        private System.Windows.Forms.TextBox textboxFather;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroLabel labelID;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}