namespace AIUB_CMS.FacultyView.Interface
{
    partial class FacultyInterface
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
            this.tabcontrolFaculty = new MetroFramework.Controls.MetroTabControl();
            this.tabFacultyInfo = new MetroFramework.Controls.MetroTabPage();
            this.tabTSF = new MetroFramework.Controls.MetroTabPage();
            this.tabAcademics = new MetroFramework.Controls.MetroTabPage();
            this.grouboxAttendance = new System.Windows.Forms.GroupBox();
            this.labelSelectCourse = new MetroFramework.Controls.MetroLabel();
            this.comboboxCourses = new MetroFramework.Controls.MetroComboBox();
            this.groupboxCourseInformation = new System.Windows.Forms.GroupBox();
            this.labelCourseName = new MetroFramework.Controls.MetroLabel();
            this.labelStudentCount = new MetroFramework.Controls.MetroLabel();
            this.textboxSSID = new MetroFramework.Controls.MetroTextBox();
            this.textboxPassword = new MetroFramework.Controls.MetroTextBox();
            this.labelSSID = new MetroFramework.Controls.MetroLabel();
            this.buttonStart = new MetroFramework.Controls.MetroButton();
            this.buttonStop = new MetroFramework.Controls.MetroButton();
            this.labelCourseNameAns = new MetroFramework.Controls.MetroLabel();
            this.labelStudentCountAns = new MetroFramework.Controls.MetroLabel();
            this.textboxStudentSearch = new MetroFramework.Controls.MetroTextBox();
            this.labelManualAttendance = new MetroFramework.Controls.MetroLabel();
            this.progressbarStudents = new MetroFramework.Controls.MetroProgressBar();
            this.labelStudentsAccountedFor = new MetroFramework.Controls.MetroLabel();
            this.labelPassword = new MetroFramework.Controls.MetroLabel();
            this.labelShutOffTime = new MetroFramework.Controls.MetroLabel();
            this.comboboxShutOff = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.labelStudentsRemainingAns = new MetroFramework.Controls.MetroLabel();
            this.labelStudentsRemaining = new MetroFramework.Controls.MetroLabel();
            this.buttonAutoCredentials = new MetroFramework.Controls.MetroButton();
            this.tabcontrolFaculty.SuspendLayout();
            this.tabAcademics.SuspendLayout();
            this.grouboxAttendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrolFaculty
            // 
            this.tabcontrolFaculty.Controls.Add(this.tabFacultyInfo);
            this.tabcontrolFaculty.Controls.Add(this.tabTSF);
            this.tabcontrolFaculty.Controls.Add(this.tabAcademics);
            this.tabcontrolFaculty.Location = new System.Drawing.Point(4, 86);
            this.tabcontrolFaculty.Name = "tabcontrolFaculty";
            this.tabcontrolFaculty.SelectedIndex = 2;
            this.tabcontrolFaculty.Size = new System.Drawing.Size(1174, 528);
            this.tabcontrolFaculty.TabIndex = 0;
            this.tabcontrolFaculty.UseSelectable = true;
            // 
            // tabFacultyInfo
            // 
            this.tabFacultyInfo.HorizontalScrollbarBarColor = true;
            this.tabFacultyInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.tabFacultyInfo.HorizontalScrollbarSize = 10;
            this.tabFacultyInfo.Location = new System.Drawing.Point(4, 38);
            this.tabFacultyInfo.Name = "tabFacultyInfo";
            this.tabFacultyInfo.Size = new System.Drawing.Size(1166, 486);
            this.tabFacultyInfo.TabIndex = 0;
            this.tabFacultyInfo.Text = "Faculty Information";
            this.tabFacultyInfo.VerticalScrollbarBarColor = true;
            this.tabFacultyInfo.VerticalScrollbarHighlightOnWheel = false;
            this.tabFacultyInfo.VerticalScrollbarSize = 10;
            // 
            // tabTSF
            // 
            this.tabTSF.HorizontalScrollbarBarColor = true;
            this.tabTSF.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTSF.HorizontalScrollbarSize = 10;
            this.tabTSF.Location = new System.Drawing.Point(4, 38);
            this.tabTSF.Name = "tabTSF";
            this.tabTSF.Size = new System.Drawing.Size(1166, 486);
            this.tabTSF.TabIndex = 1;
            this.tabTSF.Text = "TSF";
            this.tabTSF.VerticalScrollbarBarColor = true;
            this.tabTSF.VerticalScrollbarHighlightOnWheel = false;
            this.tabTSF.VerticalScrollbarSize = 10;
            // 
            // tabAcademics
            // 
            this.tabAcademics.Controls.Add(this.groupboxCourseInformation);
            this.tabAcademics.Controls.Add(this.comboboxCourses);
            this.tabAcademics.Controls.Add(this.labelSelectCourse);
            this.tabAcademics.Controls.Add(this.grouboxAttendance);
            this.tabAcademics.HorizontalScrollbarBarColor = true;
            this.tabAcademics.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAcademics.HorizontalScrollbarSize = 10;
            this.tabAcademics.Location = new System.Drawing.Point(4, 38);
            this.tabAcademics.Name = "tabAcademics";
            this.tabAcademics.Size = new System.Drawing.Size(1166, 486);
            this.tabAcademics.TabIndex = 2;
            this.tabAcademics.Text = "Academics";
            this.tabAcademics.VerticalScrollbarBarColor = true;
            this.tabAcademics.VerticalScrollbarHighlightOnWheel = false;
            this.tabAcademics.VerticalScrollbarSize = 10;
            // 
            // grouboxAttendance
            // 
            this.grouboxAttendance.BackColor = System.Drawing.Color.Transparent;
            this.grouboxAttendance.Controls.Add(this.buttonAutoCredentials);
            this.grouboxAttendance.Controls.Add(this.labelStudentsRemainingAns);
            this.grouboxAttendance.Controls.Add(this.labelStudentsRemaining);
            this.grouboxAttendance.Controls.Add(this.metroButton1);
            this.grouboxAttendance.Controls.Add(this.comboboxShutOff);
            this.grouboxAttendance.Controls.Add(this.labelShutOffTime);
            this.grouboxAttendance.Controls.Add(this.labelPassword);
            this.grouboxAttendance.Controls.Add(this.labelStudentsAccountedFor);
            this.grouboxAttendance.Controls.Add(this.progressbarStudents);
            this.grouboxAttendance.Controls.Add(this.labelManualAttendance);
            this.grouboxAttendance.Controls.Add(this.textboxStudentSearch);
            this.grouboxAttendance.Controls.Add(this.labelStudentCountAns);
            this.grouboxAttendance.Controls.Add(this.labelCourseNameAns);
            this.grouboxAttendance.Controls.Add(this.buttonStop);
            this.grouboxAttendance.Controls.Add(this.buttonStart);
            this.grouboxAttendance.Controls.Add(this.labelSSID);
            this.grouboxAttendance.Controls.Add(this.textboxPassword);
            this.grouboxAttendance.Controls.Add(this.textboxSSID);
            this.grouboxAttendance.Controls.Add(this.labelStudentCount);
            this.grouboxAttendance.Controls.Add(this.labelCourseName);
            this.grouboxAttendance.Location = new System.Drawing.Point(411, 32);
            this.grouboxAttendance.Name = "grouboxAttendance";
            this.grouboxAttendance.Size = new System.Drawing.Size(752, 451);
            this.grouboxAttendance.TabIndex = 2;
            this.grouboxAttendance.TabStop = false;
            this.grouboxAttendance.Text = "CourseAttendance";
            // 
            // labelSelectCourse
            // 
            this.labelSelectCourse.AutoSize = true;
            this.labelSelectCourse.Location = new System.Drawing.Point(22, 32);
            this.labelSelectCourse.Name = "labelSelectCourse";
            this.labelSelectCourse.Size = new System.Drawing.Size(91, 19);
            this.labelSelectCourse.TabIndex = 0;
            this.labelSelectCourse.Text = "Select Course:";
            // 
            // comboboxCourses
            // 
            this.comboboxCourses.FormattingEnabled = true;
            this.comboboxCourses.ItemHeight = 23;
            this.comboboxCourses.Location = new System.Drawing.Point(119, 32);
            this.comboboxCourses.Name = "comboboxCourses";
            this.comboboxCourses.Size = new System.Drawing.Size(243, 29);
            this.comboboxCourses.TabIndex = 3;
            this.comboboxCourses.UseSelectable = true;
            // 
            // groupboxCourseInformation
            // 
            this.groupboxCourseInformation.BackColor = System.Drawing.Color.Transparent;
            this.groupboxCourseInformation.Location = new System.Drawing.Point(22, 135);
            this.groupboxCourseInformation.Name = "groupboxCourseInformation";
            this.groupboxCourseInformation.Size = new System.Drawing.Size(359, 348);
            this.groupboxCourseInformation.TabIndex = 4;
            this.groupboxCourseInformation.TabStop = false;
            this.groupboxCourseInformation.Text = "Course Information";
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Location = new System.Drawing.Point(37, 35);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(93, 19);
            this.labelCourseName.TabIndex = 0;
            this.labelCourseName.Text = "Course Name:";
            // 
            // labelStudentCount
            // 
            this.labelStudentCount.AutoSize = true;
            this.labelStudentCount.Location = new System.Drawing.Point(37, 68);
            this.labelStudentCount.Name = "labelStudentCount";
            this.labelStudentCount.Size = new System.Drawing.Size(95, 19);
            this.labelStudentCount.TabIndex = 1;
            this.labelStudentCount.Text = "Student Count:";
            // 
            // textboxSSID
            // 
            // 
            // 
            // 
            this.textboxSSID.CustomButton.Image = null;
            this.textboxSSID.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.textboxSSID.CustomButton.Name = "";
            this.textboxSSID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxSSID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxSSID.CustomButton.TabIndex = 1;
            this.textboxSSID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxSSID.CustomButton.UseSelectable = true;
            this.textboxSSID.CustomButton.Visible = false;
            this.textboxSSID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textboxSSID.Lines = new string[0];
            this.textboxSSID.Location = new System.Drawing.Point(199, 144);
            this.textboxSSID.MaxLength = 32767;
            this.textboxSSID.Name = "textboxSSID";
            this.textboxSSID.PasswordChar = '\0';
            this.textboxSSID.PromptText = "SSID";
            this.textboxSSID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxSSID.SelectedText = "";
            this.textboxSSID.SelectionLength = 0;
            this.textboxSSID.SelectionStart = 0;
            this.textboxSSID.ShortcutsEnabled = true;
            this.textboxSSID.Size = new System.Drawing.Size(121, 23);
            this.textboxSSID.TabIndex = 2;
            this.textboxSSID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxSSID.UseSelectable = true;
            this.textboxSSID.WaterMark = "SSID";
            this.textboxSSID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxSSID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textboxPassword
            // 
            // 
            // 
            // 
            this.textboxPassword.CustomButton.Image = null;
            this.textboxPassword.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.textboxPassword.CustomButton.Name = "";
            this.textboxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxPassword.CustomButton.TabIndex = 1;
            this.textboxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxPassword.CustomButton.UseSelectable = true;
            this.textboxPassword.CustomButton.Visible = false;
            this.textboxPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textboxPassword.Lines = new string[0];
            this.textboxPassword.Location = new System.Drawing.Point(199, 173);
            this.textboxPassword.MaxLength = 32767;
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '\0';
            this.textboxPassword.PromptText = "Password";
            this.textboxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxPassword.SelectedText = "";
            this.textboxPassword.SelectionLength = 0;
            this.textboxPassword.SelectionStart = 0;
            this.textboxPassword.ShortcutsEnabled = true;
            this.textboxPassword.Size = new System.Drawing.Size(121, 23);
            this.textboxPassword.TabIndex = 3;
            this.textboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxPassword.UseSelectable = true;
            this.textboxPassword.WaterMark = "Password";
            this.textboxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelSSID
            // 
            this.labelSSID.AutoSize = true;
            this.labelSSID.Location = new System.Drawing.Point(37, 144);
            this.labelSSID.Name = "labelSSID";
            this.labelSSID.Size = new System.Drawing.Size(84, 19);
            this.labelSSID.TabIndex = 5;
            this.labelSSID.Text = "HotspotSSID:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(37, 204);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(84, 40);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseSelectable = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(137, 204);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(84, 40);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseSelectable = true;
            // 
            // labelCourseNameAns
            // 
            this.labelCourseNameAns.AutoSize = true;
            this.labelCourseNameAns.Location = new System.Drawing.Point(199, 35);
            this.labelCourseNameAns.Name = "labelCourseNameAns";
            this.labelCourseNameAns.Size = new System.Drawing.Size(107, 19);
            this.labelCourseNameAns.TabIndex = 8;
            this.labelCourseNameAns.Text = "CourseNameAns";
            // 
            // labelStudentCountAns
            // 
            this.labelStudentCountAns.AutoSize = true;
            this.labelStudentCountAns.Location = new System.Drawing.Point(199, 68);
            this.labelStudentCountAns.Name = "labelStudentCountAns";
            this.labelStudentCountAns.Size = new System.Drawing.Size(109, 19);
            this.labelStudentCountAns.TabIndex = 9;
            this.labelStudentCountAns.Text = "StudentCountAns";
            // 
            // textboxStudentSearch
            // 
            // 
            // 
            // 
            this.textboxStudentSearch.CustomButton.Image = null;
            this.textboxStudentSearch.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.textboxStudentSearch.CustomButton.Name = "";
            this.textboxStudentSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxStudentSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxStudentSearch.CustomButton.TabIndex = 1;
            this.textboxStudentSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxStudentSearch.CustomButton.UseSelectable = true;
            this.textboxStudentSearch.CustomButton.Visible = false;
            this.textboxStudentSearch.Lines = new string[0];
            this.textboxStudentSearch.Location = new System.Drawing.Point(199, 265);
            this.textboxStudentSearch.MaxLength = 32767;
            this.textboxStudentSearch.Name = "textboxStudentSearch";
            this.textboxStudentSearch.PasswordChar = '\0';
            this.textboxStudentSearch.PromptText = "Enter Student ID";
            this.textboxStudentSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxStudentSearch.SelectedText = "";
            this.textboxStudentSearch.SelectionLength = 0;
            this.textboxStudentSearch.SelectionStart = 0;
            this.textboxStudentSearch.ShortcutsEnabled = true;
            this.textboxStudentSearch.Size = new System.Drawing.Size(145, 23);
            this.textboxStudentSearch.TabIndex = 10;
            this.textboxStudentSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxStudentSearch.UseSelectable = true;
            this.textboxStudentSearch.WaterMark = "Enter Student ID";
            this.textboxStudentSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxStudentSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelManualAttendance
            // 
            this.labelManualAttendance.AutoSize = true;
            this.labelManualAttendance.Location = new System.Drawing.Point(37, 265);
            this.labelManualAttendance.Name = "labelManualAttendance";
            this.labelManualAttendance.Size = new System.Drawing.Size(125, 19);
            this.labelManualAttendance.TabIndex = 12;
            this.labelManualAttendance.Text = "Manual Attendance:";
            // 
            // progressbarStudents
            // 
            this.progressbarStudents.Location = new System.Drawing.Point(199, 342);
            this.progressbarStudents.Maximum = 40;
            this.progressbarStudents.Name = "progressbarStudents";
            this.progressbarStudents.Size = new System.Drawing.Size(145, 23);
            this.progressbarStudents.Step = 1;
            this.progressbarStudents.TabIndex = 5;
            // 
            // labelStudentsAccountedFor
            // 
            this.labelStudentsAccountedFor.AutoSize = true;
            this.labelStudentsAccountedFor.Location = new System.Drawing.Point(37, 342);
            this.labelStudentsAccountedFor.Name = "labelStudentsAccountedFor";
            this.labelStudentsAccountedFor.Size = new System.Drawing.Size(61, 19);
            this.labelStudentsAccountedFor.TabIndex = 13;
            this.labelStudentsAccountedFor.Text = "Students:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(37, 173);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(66, 19);
            this.labelPassword.TabIndex = 15;
            this.labelPassword.Text = "Password:";
            // 
            // labelShutOffTime
            // 
            this.labelShutOffTime.AutoSize = true;
            this.labelShutOffTime.Location = new System.Drawing.Point(37, 103);
            this.labelShutOffTime.Name = "labelShutOffTime";
            this.labelShutOffTime.Size = new System.Drawing.Size(132, 19);
            this.labelShutOffTime.TabIndex = 16;
            this.labelShutOffTime.Text = "Select Shut-Off Time:";
            // 
            // comboboxShutOff
            // 
            this.comboboxShutOff.FormattingEnabled = true;
            this.comboboxShutOff.ItemHeight = 23;
            this.comboboxShutOff.Location = new System.Drawing.Point(199, 103);
            this.comboboxShutOff.Name = "comboboxShutOff";
            this.comboboxShutOff.Size = new System.Drawing.Size(121, 29);
            this.comboboxShutOff.TabIndex = 17;
            this.comboboxShutOff.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(199, 296);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(100, 40);
            this.metroButton1.TabIndex = 18;
            this.metroButton1.Text = "Add";
            this.metroButton1.UseSelectable = true;
            // 
            // labelStudentsRemainingAns
            // 
            this.labelStudentsRemainingAns.AutoSize = true;
            this.labelStudentsRemainingAns.Location = new System.Drawing.Point(199, 375);
            this.labelStudentsRemainingAns.Name = "labelStudentsRemainingAns";
            this.labelStudentsRemainingAns.Size = new System.Drawing.Size(141, 19);
            this.labelStudentsRemainingAns.TabIndex = 20;
            this.labelStudentsRemainingAns.Text = "StudentsRemainingAns";
            // 
            // labelStudentsRemaining
            // 
            this.labelStudentsRemaining.AutoSize = true;
            this.labelStudentsRemaining.Location = new System.Drawing.Point(37, 375);
            this.labelStudentsRemaining.Name = "labelStudentsRemaining";
            this.labelStudentsRemaining.Size = new System.Drawing.Size(127, 19);
            this.labelStudentsRemaining.TabIndex = 19;
            this.labelStudentsRemaining.Text = "Students Remaining:";
            // 
            // buttonAutoCredentials
            // 
            this.buttonAutoCredentials.Location = new System.Drawing.Point(236, 204);
            this.buttonAutoCredentials.Name = "buttonAutoCredentials";
            this.buttonAutoCredentials.Size = new System.Drawing.Size(84, 40);
            this.buttonAutoCredentials.TabIndex = 21;
            this.buttonAutoCredentials.Text = "Auto";
            this.buttonAutoCredentials.UseSelectable = true;
            // 
            // FacultyInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.tabcontrolFaculty);
            this.Name = "FacultyInterface";
            this.Text = "FacultyInterface";
            this.tabcontrolFaculty.ResumeLayout(false);
            this.tabAcademics.ResumeLayout(false);
            this.tabAcademics.PerformLayout();
            this.grouboxAttendance.ResumeLayout(false);
            this.grouboxAttendance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabcontrolFaculty;
        private MetroFramework.Controls.MetroTabPage tabFacultyInfo;
        private MetroFramework.Controls.MetroTabPage tabTSF;
        private MetroFramework.Controls.MetroTabPage tabAcademics;
        private System.Windows.Forms.GroupBox groupboxCourseInformation;
        private MetroFramework.Controls.MetroComboBox comboboxCourses;
        private MetroFramework.Controls.MetroLabel labelSelectCourse;
        private System.Windows.Forms.GroupBox grouboxAttendance;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox comboboxShutOff;
        private MetroFramework.Controls.MetroLabel labelShutOffTime;
        private MetroFramework.Controls.MetroLabel labelPassword;
        private MetroFramework.Controls.MetroLabel labelStudentsAccountedFor;
        private MetroFramework.Controls.MetroProgressBar progressbarStudents;
        private MetroFramework.Controls.MetroLabel labelManualAttendance;
        private MetroFramework.Controls.MetroTextBox textboxStudentSearch;
        private MetroFramework.Controls.MetroLabel labelStudentCountAns;
        private MetroFramework.Controls.MetroLabel labelCourseNameAns;
        private MetroFramework.Controls.MetroButton buttonStop;
        private MetroFramework.Controls.MetroButton buttonStart;
        private MetroFramework.Controls.MetroLabel labelSSID;
        private MetroFramework.Controls.MetroTextBox textboxPassword;
        private MetroFramework.Controls.MetroTextBox textboxSSID;
        private MetroFramework.Controls.MetroLabel labelStudentCount;
        private MetroFramework.Controls.MetroLabel labelCourseName;
        private MetroFramework.Controls.MetroLabel labelStudentsRemainingAns;
        private MetroFramework.Controls.MetroLabel labelStudentsRemaining;
        private MetroFramework.Controls.MetroButton buttonAutoCredentials;
    }
}