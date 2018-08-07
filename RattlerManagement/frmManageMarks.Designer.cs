namespace RattlerManagement
{
    partial class frmManageMarks
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
            this.lstboxStudents = new System.Windows.Forms.ListBox();
            this.txt_KU = new System.Windows.Forms.TextBox();
            this.txt_Application = new System.Windows.Forms.TextBox();
            this.txt_TI = new System.Windows.Forms.TextBox();
            this.txt_Comm = new System.Windows.Forms.TextBox();
            this.txt_Culm = new System.Windows.Forms.TextBox();
            this.txt_Exams = new System.Windows.Forms.TextBox();
            this.lbl_KU = new System.Windows.Forms.Label();
            this.lbl_App = new System.Windows.Forms.Label();
            this.lbl_TI = new System.Windows.Forms.Label();
            this.lbl_Comm = new System.Windows.Forms.Label();
            this.lbl_Culm = new System.Windows.Forms.Label();
            this.lbl_Exams = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lbl_KUShow = new System.Windows.Forms.Label();
            this.lbl_AppShow = new System.Windows.Forms.Label();
            this.lblTIShow = new System.Windows.Forms.Label();
            this.lbl_CommShow = new System.Windows.Forms.Label();
            this.lbl_CulmShow = new System.Windows.Forms.Label();
            this.lbl_ExamShow = new System.Windows.Forms.Label();
            this.lblTotalMark = new System.Windows.Forms.Label();
            this.btnUpdateMark = new System.Windows.Forms.Button();
            this.Marks = new System.Windows.Forms.GroupBox();
            this.lsbStudentName = new System.Windows.Forms.ListBox();
            this.grpStudentInformation = new System.Windows.Forms.GroupBox();
            this.pctBoxStudent = new System.Windows.Forms.PictureBox();
            this.lblSHomeAddress = new System.Windows.Forms.Label();
            this.lblSPhoneNumber = new System.Windows.Forms.Label();
            this.lblSParentName = new System.Windows.Forms.Label();
            this.lblSGrade = new System.Windows.Forms.Label();
            this.lblSEmail = new System.Windows.Forms.Label();
            this.lblSAge = new System.Windows.Forms.Label();
            this.lblsDOB = new System.Windows.Forms.Label();
            this.lblsLastName = new System.Windows.Forms.Label();
            this.lblSFirstName = new System.Windows.Forms.Label();
            this.btnSortCourses = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.edusistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Marks.SuspendLayout();
            this.grpStudentInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxStudent)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstboxStudents
            // 
            this.lstboxStudents.FormattingEnabled = true;
            this.lstboxStudents.Location = new System.Drawing.Point(13, 53);
            this.lstboxStudents.Name = "lstboxStudents";
            this.lstboxStudents.Size = new System.Drawing.Size(79, 186);
            this.lstboxStudents.TabIndex = 0;
            this.lstboxStudents.SelectedIndexChanged += new System.EventHandler(this.lstboxStudents_SelectedIndexChanged);
            // 
            // txt_KU
            // 
            this.txt_KU.Location = new System.Drawing.Point(610, 52);
            this.txt_KU.Name = "txt_KU";
            this.txt_KU.Size = new System.Drawing.Size(100, 20);
            this.txt_KU.TabIndex = 1;
            // 
            // txt_Application
            // 
            this.txt_Application.Location = new System.Drawing.Point(610, 78);
            this.txt_Application.Name = "txt_Application";
            this.txt_Application.Size = new System.Drawing.Size(100, 20);
            this.txt_Application.TabIndex = 2;
            // 
            // txt_TI
            // 
            this.txt_TI.Location = new System.Drawing.Point(610, 104);
            this.txt_TI.Name = "txt_TI";
            this.txt_TI.Size = new System.Drawing.Size(100, 20);
            this.txt_TI.TabIndex = 3;
            // 
            // txt_Comm
            // 
            this.txt_Comm.Location = new System.Drawing.Point(610, 130);
            this.txt_Comm.Name = "txt_Comm";
            this.txt_Comm.Size = new System.Drawing.Size(100, 20);
            this.txt_Comm.TabIndex = 4;
            // 
            // txt_Culm
            // 
            this.txt_Culm.Location = new System.Drawing.Point(610, 156);
            this.txt_Culm.Name = "txt_Culm";
            this.txt_Culm.Size = new System.Drawing.Size(100, 20);
            this.txt_Culm.TabIndex = 5;
            // 
            // txt_Exams
            // 
            this.txt_Exams.Location = new System.Drawing.Point(610, 182);
            this.txt_Exams.Name = "txt_Exams";
            this.txt_Exams.Size = new System.Drawing.Size(100, 20);
            this.txt_Exams.TabIndex = 6;
            // 
            // lbl_KU
            // 
            this.lbl_KU.AutoSize = true;
            this.lbl_KU.BackColor = System.Drawing.Color.Transparent;
            this.lbl_KU.Location = new System.Drawing.Point(524, 59);
            this.lbl_KU.Name = "lbl_KU";
            this.lbl_KU.Size = new System.Drawing.Size(22, 13);
            this.lbl_KU.TabIndex = 7;
            this.lbl_KU.Text = "KU";
            // 
            // lbl_App
            // 
            this.lbl_App.AutoSize = true;
            this.lbl_App.BackColor = System.Drawing.Color.Transparent;
            this.lbl_App.Location = new System.Drawing.Point(524, 85);
            this.lbl_App.Name = "lbl_App";
            this.lbl_App.Size = new System.Drawing.Size(59, 13);
            this.lbl_App.TabIndex = 8;
            this.lbl_App.Text = "Application";
            // 
            // lbl_TI
            // 
            this.lbl_TI.AutoSize = true;
            this.lbl_TI.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TI.Location = new System.Drawing.Point(524, 111);
            this.lbl_TI.Name = "lbl_TI";
            this.lbl_TI.Size = new System.Drawing.Size(22, 13);
            this.lbl_TI.TabIndex = 9;
            this.lbl_TI.Text = "T/I";
            // 
            // lbl_Comm
            // 
            this.lbl_Comm.AutoSize = true;
            this.lbl_Comm.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Comm.Location = new System.Drawing.Point(524, 137);
            this.lbl_Comm.Name = "lbl_Comm";
            this.lbl_Comm.Size = new System.Drawing.Size(79, 13);
            this.lbl_Comm.TabIndex = 10;
            this.lbl_Comm.Text = "Communication";
            // 
            // lbl_Culm
            // 
            this.lbl_Culm.AutoSize = true;
            this.lbl_Culm.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Culm.Location = new System.Drawing.Point(524, 163);
            this.lbl_Culm.Name = "lbl_Culm";
            this.lbl_Culm.Size = new System.Drawing.Size(61, 13);
            this.lbl_Culm.TabIndex = 11;
            this.lbl_Culm.Text = "Culminating";
            // 
            // lbl_Exams
            // 
            this.lbl_Exams.AutoSize = true;
            this.lbl_Exams.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Exams.Location = new System.Drawing.Point(524, 189);
            this.lbl_Exams.Name = "lbl_Exams";
            this.lbl_Exams.Size = new System.Drawing.Size(38, 13);
            this.lbl_Exams.TabIndex = 12;
            this.lbl_Exams.Text = "Exams";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblInformation.Location = new System.Drawing.Point(199, 55);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(23, 13);
            this.lblInformation.TabIndex = 13;
            this.lblInformation.Text = "null";
            // 
            // lbl_KUShow
            // 
            this.lbl_KUShow.AutoSize = true;
            this.lbl_KUShow.Location = new System.Drawing.Point(6, 36);
            this.lbl_KUShow.Name = "lbl_KUShow";
            this.lbl_KUShow.Size = new System.Drawing.Size(30, 13);
            this.lbl_KUShow.TabIndex = 14;
            this.lbl_KUShow.Text = "K/U:";
            // 
            // lbl_AppShow
            // 
            this.lbl_AppShow.AutoSize = true;
            this.lbl_AppShow.Location = new System.Drawing.Point(4, 60);
            this.lbl_AppShow.Name = "lbl_AppShow";
            this.lbl_AppShow.Size = new System.Drawing.Size(62, 13);
            this.lbl_AppShow.TabIndex = 15;
            this.lbl_AppShow.Text = "Application:";
            // 
            // lblTIShow
            // 
            this.lblTIShow.AutoSize = true;
            this.lblTIShow.Location = new System.Drawing.Point(4, 83);
            this.lblTIShow.Name = "lblTIShow";
            this.lblTIShow.Size = new System.Drawing.Size(25, 13);
            this.lblTIShow.TabIndex = 16;
            this.lblTIShow.Text = "T/I:";
            // 
            // lbl_CommShow
            // 
            this.lbl_CommShow.AutoSize = true;
            this.lbl_CommShow.Location = new System.Drawing.Point(4, 109);
            this.lbl_CommShow.Name = "lbl_CommShow";
            this.lbl_CommShow.Size = new System.Drawing.Size(82, 13);
            this.lbl_CommShow.TabIndex = 17;
            this.lbl_CommShow.Text = "Communication:";
            // 
            // lbl_CulmShow
            // 
            this.lbl_CulmShow.AutoSize = true;
            this.lbl_CulmShow.Location = new System.Drawing.Point(150, 60);
            this.lbl_CulmShow.Name = "lbl_CulmShow";
            this.lbl_CulmShow.Size = new System.Drawing.Size(64, 13);
            this.lbl_CulmShow.TabIndex = 18;
            this.lbl_CulmShow.Text = "Culminating:";
            // 
            // lbl_ExamShow
            // 
            this.lbl_ExamShow.AutoSize = true;
            this.lbl_ExamShow.Location = new System.Drawing.Point(150, 86);
            this.lbl_ExamShow.Name = "lbl_ExamShow";
            this.lbl_ExamShow.Size = new System.Drawing.Size(36, 13);
            this.lbl_ExamShow.TabIndex = 19;
            this.lbl_ExamShow.Text = "Exam:";
            // 
            // lblTotalMark
            // 
            this.lblTotalMark.AutoSize = true;
            this.lblTotalMark.Location = new System.Drawing.Point(150, 109);
            this.lblTotalMark.Name = "lblTotalMark";
            this.lblTotalMark.Size = new System.Drawing.Size(58, 13);
            this.lblTotalMark.TabIndex = 20;
            this.lblTotalMark.Text = "Total Mark";
            // 
            // btnUpdateMark
            // 
            this.btnUpdateMark.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdateMark.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMark.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateMark.Location = new System.Drawing.Point(527, 214);
            this.btnUpdateMark.Name = "btnUpdateMark";
            this.btnUpdateMark.Size = new System.Drawing.Size(182, 35);
            this.btnUpdateMark.TabIndex = 21;
            this.btnUpdateMark.Text = "Submit Mark";
            this.btnUpdateMark.UseVisualStyleBackColor = false;
            this.btnUpdateMark.Click += new System.EventHandler(this.btnUpdateMark_Click);
            // 
            // Marks
            // 
            this.Marks.BackColor = System.Drawing.Color.Transparent;
            this.Marks.Controls.Add(this.lblTotalMark);
            this.Marks.Controls.Add(this.lbl_ExamShow);
            this.Marks.Controls.Add(this.lbl_CulmShow);
            this.Marks.Controls.Add(this.lbl_CommShow);
            this.Marks.Controls.Add(this.lblTIShow);
            this.Marks.Controls.Add(this.lbl_AppShow);
            this.Marks.Controls.Add(this.lbl_KUShow);
            this.Marks.Location = new System.Drawing.Point(202, 116);
            this.Marks.Name = "Marks";
            this.Marks.Size = new System.Drawing.Size(287, 136);
            this.Marks.TabIndex = 22;
            this.Marks.TabStop = false;
            this.Marks.Text = "Marks";
            // 
            // lsbStudentName
            // 
            this.lsbStudentName.FormattingEnabled = true;
            this.lsbStudentName.Location = new System.Drawing.Point(98, 53);
            this.lsbStudentName.Name = "lsbStudentName";
            this.lsbStudentName.Size = new System.Drawing.Size(79, 186);
            this.lsbStudentName.TabIndex = 23;
            // 
            // grpStudentInformation
            // 
            this.grpStudentInformation.BackColor = System.Drawing.Color.Transparent;
            this.grpStudentInformation.Controls.Add(this.pctBoxStudent);
            this.grpStudentInformation.Controls.Add(this.lblSHomeAddress);
            this.grpStudentInformation.Controls.Add(this.lblSPhoneNumber);
            this.grpStudentInformation.Controls.Add(this.lblSParentName);
            this.grpStudentInformation.Controls.Add(this.lblSGrade);
            this.grpStudentInformation.Controls.Add(this.lblSEmail);
            this.grpStudentInformation.Controls.Add(this.lblSAge);
            this.grpStudentInformation.Controls.Add(this.lblsDOB);
            this.grpStudentInformation.Controls.Add(this.lblsLastName);
            this.grpStudentInformation.Controls.Add(this.lblSFirstName);
            this.grpStudentInformation.Location = new System.Drawing.Point(13, 273);
            this.grpStudentInformation.Name = "grpStudentInformation";
            this.grpStudentInformation.Size = new System.Drawing.Size(696, 131);
            this.grpStudentInformation.TabIndex = 24;
            this.grpStudentInformation.TabStop = false;
            this.grpStudentInformation.Text = "Student Information";
            this.grpStudentInformation.Enter += new System.EventHandler(this.grpStudentInformation_Enter);
            // 
            // pctBoxStudent
            // 
            this.pctBoxStudent.Location = new System.Drawing.Point(514, 19);
            this.pctBoxStudent.Name = "pctBoxStudent";
            this.pctBoxStudent.Size = new System.Drawing.Size(150, 100);
            this.pctBoxStudent.TabIndex = 9;
            this.pctBoxStudent.TabStop = false;
            // 
            // lblSHomeAddress
            // 
            this.lblSHomeAddress.AutoSize = true;
            this.lblSHomeAddress.Location = new System.Drawing.Point(328, 91);
            this.lblSHomeAddress.Name = "lblSHomeAddress";
            this.lblSHomeAddress.Size = new System.Drawing.Size(78, 13);
            this.lblSHomeAddress.TabIndex = 8;
            this.lblSHomeAddress.Text = "sHomeAddress";
            // 
            // lblSPhoneNumber
            // 
            this.lblSPhoneNumber.AutoSize = true;
            this.lblSPhoneNumber.Location = new System.Drawing.Point(328, 56);
            this.lblSPhoneNumber.Name = "lblSPhoneNumber";
            this.lblSPhoneNumber.Size = new System.Drawing.Size(80, 13);
            this.lblSPhoneNumber.TabIndex = 7;
            this.lblSPhoneNumber.Text = "sPhoneNumber";
            // 
            // lblSParentName
            // 
            this.lblSParentName.AutoSize = true;
            this.lblSParentName.Location = new System.Drawing.Point(330, 26);
            this.lblSParentName.Name = "lblSParentName";
            this.lblSParentName.Size = new System.Drawing.Size(71, 13);
            this.lblSParentName.TabIndex = 6;
            this.lblSParentName.Text = "sParentName";
            // 
            // lblSGrade
            // 
            this.lblSGrade.AutoSize = true;
            this.lblSGrade.Location = new System.Drawing.Point(199, 90);
            this.lblSGrade.Name = "lblSGrade";
            this.lblSGrade.Size = new System.Drawing.Size(41, 13);
            this.lblSGrade.TabIndex = 5;
            this.lblSGrade.Text = "sGrade";
            // 
            // lblSEmail
            // 
            this.lblSEmail.AutoSize = true;
            this.lblSEmail.Location = new System.Drawing.Point(199, 55);
            this.lblSEmail.Name = "lblSEmail";
            this.lblSEmail.Size = new System.Drawing.Size(37, 13);
            this.lblSEmail.TabIndex = 4;
            this.lblSEmail.Text = "sEmail";
            // 
            // lblSAge
            // 
            this.lblSAge.AutoSize = true;
            this.lblSAge.Location = new System.Drawing.Point(201, 25);
            this.lblSAge.Name = "lblSAge";
            this.lblSAge.Size = new System.Drawing.Size(31, 13);
            this.lblSAge.TabIndex = 3;
            this.lblSAge.Text = "sAge";
            // 
            // lblsDOB
            // 
            this.lblsDOB.AutoSize = true;
            this.lblsDOB.Location = new System.Drawing.Point(12, 90);
            this.lblsDOB.Name = "lblsDOB";
            this.lblsDOB.Size = new System.Drawing.Size(35, 13);
            this.lblsDOB.TabIndex = 2;
            this.lblsDOB.Text = "sDOB";
            // 
            // lblsLastName
            // 
            this.lblsLastName.AutoSize = true;
            this.lblsLastName.Location = new System.Drawing.Point(12, 55);
            this.lblsLastName.Name = "lblsLastName";
            this.lblsLastName.Size = new System.Drawing.Size(60, 13);
            this.lblsLastName.TabIndex = 1;
            this.lblsLastName.Text = "sLastName";
            // 
            // lblSFirstName
            // 
            this.lblSFirstName.AutoSize = true;
            this.lblSFirstName.Location = new System.Drawing.Point(12, 25);
            this.lblSFirstName.Name = "lblSFirstName";
            this.lblSFirstName.Size = new System.Drawing.Size(51, 13);
            this.lblSFirstName.TabIndex = 0;
            this.lblSFirstName.Text = "firstName";
            // 
            // btnSortCourses
            // 
            this.btnSortCourses.Location = new System.Drawing.Point(13, 244);
            this.btnSortCourses.Name = "btnSortCourses";
            this.btnSortCourses.Size = new System.Drawing.Size(163, 26);
            this.btnSortCourses.TabIndex = 25;
            this.btnSortCourses.Text = "Sorting Marks";
            this.btnSortCourses.UseVisualStyleBackColor = true;
            this.btnSortCourses.Click += new System.EventHandler(this.btnSortCourses_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.ForestGreen;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edusistToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(724, 24);
            this.mnuMain.TabIndex = 30;
            this.mnuMain.Text = "mnuMain";
            this.mnuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuMain_ItemClicked);
            // 
            // edusistToolStripMenuItem
            // 
            this.edusistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.howToUseToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.edusistToolStripMenuItem.Name = "edusistToolStripMenuItem";
            this.edusistToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.edusistToolStripMenuItem.Text = "Edusist";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.howToUseToolStripMenuItem.Text = "How To Use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmManageMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RattlerManagement.Properties.Resources._735420;
            this.ClientSize = new System.Drawing.Size(724, 420);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.btnSortCourses);
            this.Controls.Add(this.grpStudentInformation);
            this.Controls.Add(this.lsbStudentName);
            this.Controls.Add(this.Marks);
            this.Controls.Add(this.btnUpdateMark);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lbl_Exams);
            this.Controls.Add(this.lbl_Culm);
            this.Controls.Add(this.lbl_Comm);
            this.Controls.Add(this.lbl_TI);
            this.Controls.Add(this.lbl_App);
            this.Controls.Add(this.lbl_KU);
            this.Controls.Add(this.txt_Exams);
            this.Controls.Add(this.txt_Culm);
            this.Controls.Add(this.txt_Comm);
            this.Controls.Add(this.txt_TI);
            this.Controls.Add(this.txt_Application);
            this.Controls.Add(this.txt_KU);
            this.Controls.Add(this.lstboxStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmManageMarks";
            this.Text = "Edusist: Student Mark Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManageMarks_FormClosing);
            this.Load += new System.EventHandler(this.frmManageMarks_Load);
            this.Marks.ResumeLayout(false);
            this.Marks.PerformLayout();
            this.grpStudentInformation.ResumeLayout(false);
            this.grpStudentInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxStudent)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxStudents;
        private System.Windows.Forms.TextBox txt_KU;
        private System.Windows.Forms.TextBox txt_Application;
        private System.Windows.Forms.TextBox txt_TI;
        private System.Windows.Forms.TextBox txt_Comm;
        private System.Windows.Forms.TextBox txt_Culm;
        private System.Windows.Forms.TextBox txt_Exams;
        private System.Windows.Forms.Label lbl_KU;
        private System.Windows.Forms.Label lbl_App;
        private System.Windows.Forms.Label lbl_TI;
        private System.Windows.Forms.Label lbl_Comm;
        private System.Windows.Forms.Label lbl_Culm;
        private System.Windows.Forms.Label lbl_Exams;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lbl_KUShow;
        private System.Windows.Forms.Label lbl_AppShow;
        private System.Windows.Forms.Label lblTIShow;
        private System.Windows.Forms.Label lbl_CommShow;
        private System.Windows.Forms.Label lbl_CulmShow;
        private System.Windows.Forms.Label lbl_ExamShow;
        private System.Windows.Forms.Label lblTotalMark;
        private System.Windows.Forms.Button btnUpdateMark;
        private System.Windows.Forms.GroupBox Marks;
        private System.Windows.Forms.ListBox lsbStudentName;
        private System.Windows.Forms.GroupBox grpStudentInformation;
        private System.Windows.Forms.Label lblSAge;
        private System.Windows.Forms.Label lblsDOB;
        private System.Windows.Forms.Label lblsLastName;
        private System.Windows.Forms.Label lblSFirstName;
        private System.Windows.Forms.Label lblSGrade;
        private System.Windows.Forms.Label lblSEmail;
        private System.Windows.Forms.PictureBox pctBoxStudent;
        private System.Windows.Forms.Label lblSHomeAddress;
        private System.Windows.Forms.Label lblSPhoneNumber;
        private System.Windows.Forms.Label lblSParentName;
        private System.Windows.Forms.Button btnSortCourses;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem edusistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}