namespace AIUB_CMS.StudentView.Interface
{
    partial class StudentInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInterface));
            this.tabControlStudent = new MetroFramework.Controls.MetroTabControl();
            this.tabAcademics = new MetroFramework.Controls.MetroTabPage();
            this.tabSchedule = new MetroFramework.Controls.MetroTabPage();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.groupboxStudentPersonalInformation = new System.Windows.Forms.GroupBox();
            this.labelFatherAns = new MetroFramework.Controls.MetroLabel();
            this.labelEmailAns = new MetroFramework.Controls.MetroLabel();
            this.labelName = new MetroFramework.Controls.MetroLabel();
            this.labelPhoneAns = new MetroFramework.Controls.MetroLabel();
            this.labelDOBAns = new MetroFramework.Controls.MetroLabel();
            this.labelMotherAns = new MetroFramework.Controls.MetroLabel();
            this.labelGender = new MetroFramework.Controls.MetroLabel();
            this.labelBloodGroup = new MetroFramework.Controls.MetroLabel();
            this.labelNameAns = new MetroFramework.Controls.MetroLabel();
            this.labelMother = new MetroFramework.Controls.MetroLabel();
            this.labelIDAns = new MetroFramework.Controls.MetroLabel();
            this.labelBloodGroupAns = new MetroFramework.Controls.MetroLabel();
            this.labelDepartmentAns = new MetroFramework.Controls.MetroLabel();
            this.labelPhone = new MetroFramework.Controls.MetroLabel();
            this.labelCreditsAns = new MetroFramework.Controls.MetroLabel();
            this.labelGenderAns = new MetroFramework.Controls.MetroLabel();
            this.labelCGPAAns = new MetroFramework.Controls.MetroLabel();
            this.labelEmail = new MetroFramework.Controls.MetroLabel();
            this.labelCGPA = new MetroFramework.Controls.MetroLabel();
            this.labelDOB = new MetroFramework.Controls.MetroLabel();
            this.labelDepartment = new MetroFramework.Controls.MetroLabel();
            this.labelFather = new MetroFramework.Controls.MetroLabel();
            this.labelCredits = new MetroFramework.Controls.MetroLabel();
            this.labelID = new MetroFramework.Controls.MetroLabel();
            this.tabStudentInfo = new MetroFramework.Controls.MetroTabPage();
            this.tabControlStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.groupboxStudentPersonalInformation.SuspendLayout();
            this.tabStudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlStudent
            // 
            this.tabControlStudent.Controls.Add(this.tabStudentInfo);
            this.tabControlStudent.Controls.Add(this.tabAcademics);
            this.tabControlStudent.Controls.Add(this.tabSchedule);
            this.tabControlStudent.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.tabControlStudent.Location = new System.Drawing.Point(20, 121);
            this.tabControlStudent.Name = "tabControlStudent";
            this.tabControlStudent.SelectedIndex = 0;
            this.tabControlStudent.Size = new System.Drawing.Size(1181, 490);
            this.tabControlStudent.TabIndex = 0;
            this.tabControlStudent.UseSelectable = true;
            // 
            // tabAcademics
            // 
            this.tabAcademics.HorizontalScrollbarBarColor = true;
            this.tabAcademics.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAcademics.HorizontalScrollbarSize = 10;
            this.tabAcademics.Location = new System.Drawing.Point(4, 38);
            this.tabAcademics.Name = "tabAcademics";
            this.tabAcademics.Size = new System.Drawing.Size(1173, 448);
            this.tabAcademics.TabIndex = 2;
            this.tabAcademics.Text = "Academics";
            this.tabAcademics.VerticalScrollbarBarColor = true;
            this.tabAcademics.VerticalScrollbarHighlightOnWheel = false;
            this.tabAcademics.VerticalScrollbarSize = 10;
            // 
            // tabSchedule
            // 
            this.tabSchedule.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSchedule.HorizontalScrollbarBarColor = true;
            this.tabSchedule.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSchedule.HorizontalScrollbarSize = 10;
            this.tabSchedule.Location = new System.Drawing.Point(4, 38);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Size = new System.Drawing.Size(1173, 448);
            this.tabSchedule.TabIndex = 0;
            this.tabSchedule.Text = "Schedule";
            this.tabSchedule.VerticalScrollbarBarColor = true;
            this.tabSchedule.VerticalScrollbarHighlightOnWheel = false;
            this.tabSchedule.VerticalScrollbarSize = 10;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::AIUB_CMS.StudentView.Properties.Resources.LogoCMS;
            this.pictureLogo.Location = new System.Drawing.Point(23, 10);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(119, 115);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 1;
            this.pictureLogo.TabStop = false;
            // 
            // groupboxStudentPersonalInformation
            // 
            this.groupboxStudentPersonalInformation.BackColor = System.Drawing.Color.Transparent;
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelID);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelCredits);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelFather);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelDepartment);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelDOB);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelCGPA);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelEmail);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelCGPAAns);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelGenderAns);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelCreditsAns);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelPhone);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelDepartmentAns);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelBloodGroupAns);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelIDAns);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelMother);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelNameAns);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelBloodGroup);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelGender);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelMotherAns);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelDOBAns);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelPhoneAns);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelName);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelEmailAns);
            this.groupboxStudentPersonalInformation.Controls.Add(this.labelFatherAns);
            this.groupboxStudentPersonalInformation.Location = new System.Drawing.Point(3, 16);
            this.groupboxStudentPersonalInformation.Name = "groupboxStudentPersonalInformation";
            this.groupboxStudentPersonalInformation.Size = new System.Drawing.Size(402, 429);
            this.groupboxStudentPersonalInformation.TabIndex = 2;
            this.groupboxStudentPersonalInformation.TabStop = false;
            this.groupboxStudentPersonalInformation.Text = "Personal Information";
            // 
            // labelFatherAns
            // 
            this.labelFatherAns.AutoSize = true;
            this.labelFatherAns.Location = new System.Drawing.Point(154, 60);
            this.labelFatherAns.Name = "labelFatherAns";
            this.labelFatherAns.Size = new System.Drawing.Size(0, 0);
            this.labelFatherAns.TabIndex = 18;
            // 
            // labelEmailAns
            // 
            this.labelEmailAns.AutoSize = true;
            this.labelEmailAns.Location = new System.Drawing.Point(154, 157);
            this.labelEmailAns.Name = "labelEmailAns";
            this.labelEmailAns.Size = new System.Drawing.Size(0, 0);
            this.labelEmailAns.TabIndex = 17;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelName.Location = new System.Drawing.Point(23, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 19);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name: ";
            // 
            // labelPhoneAns
            // 
            this.labelPhoneAns.AutoSize = true;
            this.labelPhoneAns.Location = new System.Drawing.Point(154, 126);
            this.labelPhoneAns.Name = "labelPhoneAns";
            this.labelPhoneAns.Size = new System.Drawing.Size(0, 0);
            this.labelPhoneAns.TabIndex = 22;
            // 
            // labelDOBAns
            // 
            this.labelDOBAns.AutoSize = true;
            this.labelDOBAns.Location = new System.Drawing.Point(154, 188);
            this.labelDOBAns.Name = "labelDOBAns";
            this.labelDOBAns.Size = new System.Drawing.Size(0, 0);
            this.labelDOBAns.TabIndex = 16;
            // 
            // labelMotherAns
            // 
            this.labelMotherAns.AutoSize = true;
            this.labelMotherAns.Location = new System.Drawing.Point(154, 94);
            this.labelMotherAns.Name = "labelMotherAns";
            this.labelMotherAns.Size = new System.Drawing.Size(0, 0);
            this.labelMotherAns.TabIndex = 23;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelGender.Location = new System.Drawing.Point(22, 221);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(57, 19);
            this.labelGender.TabIndex = 14;
            this.labelGender.Text = "Gender:";
            // 
            // labelBloodGroup
            // 
            this.labelBloodGroup.AutoSize = true;
            this.labelBloodGroup.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelBloodGroup.Location = new System.Drawing.Point(22, 255);
            this.labelBloodGroup.Name = "labelBloodGroup";
            this.labelBloodGroup.Size = new System.Drawing.Size(90, 19);
            this.labelBloodGroup.TabIndex = 13;
            this.labelBloodGroup.Text = "Blood Group:";
            // 
            // labelNameAns
            // 
            this.labelNameAns.AutoSize = true;
            this.labelNameAns.Location = new System.Drawing.Point(155, 28);
            this.labelNameAns.Name = "labelNameAns";
            this.labelNameAns.Size = new System.Drawing.Size(0, 0);
            this.labelNameAns.TabIndex = 15;
            // 
            // labelMother
            // 
            this.labelMother.AutoSize = true;
            this.labelMother.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelMother.Location = new System.Drawing.Point(22, 94);
            this.labelMother.Name = "labelMother";
            this.labelMother.Size = new System.Drawing.Size(104, 19);
            this.labelMother.TabIndex = 10;
            this.labelMother.Text = "Mother\'s Name";
            // 
            // labelIDAns
            // 
            this.labelIDAns.AutoSize = true;
            this.labelIDAns.Location = new System.Drawing.Point(154, 289);
            this.labelIDAns.Name = "labelIDAns";
            this.labelIDAns.Size = new System.Drawing.Size(0, 0);
            this.labelIDAns.TabIndex = 20;
            // 
            // labelBloodGroupAns
            // 
            this.labelBloodGroupAns.AutoSize = true;
            this.labelBloodGroupAns.Location = new System.Drawing.Point(154, 255);
            this.labelBloodGroupAns.Name = "labelBloodGroupAns";
            this.labelBloodGroupAns.Size = new System.Drawing.Size(0, 0);
            this.labelBloodGroupAns.TabIndex = 26;
            // 
            // labelDepartmentAns
            // 
            this.labelDepartmentAns.AutoSize = true;
            this.labelDepartmentAns.Location = new System.Drawing.Point(154, 392);
            this.labelDepartmentAns.Name = "labelDepartmentAns";
            this.labelDepartmentAns.Size = new System.Drawing.Size(0, 0);
            this.labelDepartmentAns.TabIndex = 24;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelPhone.Location = new System.Drawing.Point(22, 126);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(51, 19);
            this.labelPhone.TabIndex = 9;
            this.labelPhone.Text = "Phone:";
            // 
            // labelCreditsAns
            // 
            this.labelCreditsAns.AutoSize = true;
            this.labelCreditsAns.Location = new System.Drawing.Point(154, 357);
            this.labelCreditsAns.Name = "labelCreditsAns";
            this.labelCreditsAns.Size = new System.Drawing.Size(0, 0);
            this.labelCreditsAns.TabIndex = 19;
            // 
            // labelGenderAns
            // 
            this.labelGenderAns.AutoSize = true;
            this.labelGenderAns.Location = new System.Drawing.Point(154, 221);
            this.labelGenderAns.Name = "labelGenderAns";
            this.labelGenderAns.Size = new System.Drawing.Size(0, 0);
            this.labelGenderAns.TabIndex = 27;
            // 
            // labelCGPAAns
            // 
            this.labelCGPAAns.AutoSize = true;
            this.labelCGPAAns.Location = new System.Drawing.Point(154, 322);
            this.labelCGPAAns.Name = "labelCGPAAns";
            this.labelCGPAAns.Size = new System.Drawing.Size(0, 0);
            this.labelCGPAAns.TabIndex = 25;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelEmail.Location = new System.Drawing.Point(22, 157);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 19);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email:";
            // 
            // labelCGPA
            // 
            this.labelCGPA.AutoSize = true;
            this.labelCGPA.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelCGPA.Location = new System.Drawing.Point(22, 322);
            this.labelCGPA.Name = "labelCGPA";
            this.labelCGPA.Size = new System.Drawing.Size(47, 19);
            this.labelCGPA.TabIndex = 12;
            this.labelCGPA.Text = "CGPA:";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelDOB.Location = new System.Drawing.Point(22, 188);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(41, 19);
            this.labelDOB.TabIndex = 3;
            this.labelDOB.Text = "DOB:";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelDepartment.Location = new System.Drawing.Point(22, 392);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(86, 19);
            this.labelDepartment.TabIndex = 11;
            this.labelDepartment.Text = "Department:";
            // 
            // labelFather
            // 
            this.labelFather.AutoSize = true;
            this.labelFather.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelFather.Location = new System.Drawing.Point(22, 60);
            this.labelFather.Name = "labelFather";
            this.labelFather.Size = new System.Drawing.Size(100, 19);
            this.labelFather.TabIndex = 5;
            this.labelFather.Text = "Father\'s Name:";
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelCredits.Location = new System.Drawing.Point(22, 357);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(126, 19);
            this.labelCredits.TabIndex = 6;
            this.labelCredits.Text = "Credits Completed:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelID.Location = new System.Drawing.Point(22, 289);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 19);
            this.labelID.TabIndex = 7;
            this.labelID.Text = "ID:";
            // 
            // tabStudentInfo
            // 
            this.tabStudentInfo.Controls.Add(this.groupboxStudentPersonalInformation);
            this.tabStudentInfo.HorizontalScrollbarBarColor = true;
            this.tabStudentInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.tabStudentInfo.HorizontalScrollbarSize = 10;
            this.tabStudentInfo.Location = new System.Drawing.Point(4, 38);
            this.tabStudentInfo.Name = "tabStudentInfo";
            this.tabStudentInfo.Size = new System.Drawing.Size(1173, 448);
            this.tabStudentInfo.TabIndex = 3;
            this.tabStudentInfo.Text = "Student Info";
            this.tabStudentInfo.VerticalScrollbarBarColor = true;
            this.tabStudentInfo.VerticalScrollbarHighlightOnWheel = false;
            this.tabStudentInfo.VerticalScrollbarSize = 10;
            // 
            // StudentInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.tabControlStudent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentInterface";
            this.Text = "Welcome";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.tabControlStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.groupboxStudentPersonalInformation.ResumeLayout(false);
            this.groupboxStudentPersonalInformation.PerformLayout();
            this.tabStudentInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControlStudent;
        private MetroFramework.Controls.MetroTabPage tabSchedule;
        private MetroFramework.Controls.MetroTabPage tabAcademics;
        private System.Windows.Forms.PictureBox pictureLogo;
        private MetroFramework.Controls.MetroTabPage tabStudentInfo;
        private System.Windows.Forms.GroupBox groupboxStudentPersonalInformation;
        private MetroFramework.Controls.MetroLabel labelID;
        private MetroFramework.Controls.MetroLabel labelCredits;
        private MetroFramework.Controls.MetroLabel labelFather;
        private MetroFramework.Controls.MetroLabel labelDepartment;
        private MetroFramework.Controls.MetroLabel labelDOB;
        private MetroFramework.Controls.MetroLabel labelCGPA;
        private MetroFramework.Controls.MetroLabel labelEmail;
        private MetroFramework.Controls.MetroLabel labelCGPAAns;
        private MetroFramework.Controls.MetroLabel labelGenderAns;
        private MetroFramework.Controls.MetroLabel labelCreditsAns;
        private MetroFramework.Controls.MetroLabel labelPhone;
        private MetroFramework.Controls.MetroLabel labelDepartmentAns;
        private MetroFramework.Controls.MetroLabel labelBloodGroupAns;
        private MetroFramework.Controls.MetroLabel labelIDAns;
        private MetroFramework.Controls.MetroLabel labelMother;
        private MetroFramework.Controls.MetroLabel labelNameAns;
        private MetroFramework.Controls.MetroLabel labelBloodGroup;
        private MetroFramework.Controls.MetroLabel labelGender;
        private MetroFramework.Controls.MetroLabel labelMotherAns;
        private MetroFramework.Controls.MetroLabel labelDOBAns;
        private MetroFramework.Controls.MetroLabel labelPhoneAns;
        private MetroFramework.Controls.MetroLabel labelName;
        private MetroFramework.Controls.MetroLabel labelEmailAns;
        private MetroFramework.Controls.MetroLabel labelFatherAns;
    }
}