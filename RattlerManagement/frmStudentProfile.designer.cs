namespace RattlerManagement
{
    partial class frmStudentProfile
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
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.lstboxCourses = new System.Windows.Forms.ListBox();
            this.lblMarkDisplay = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContactTeacher = new System.Windows.Forms.Label();
            this.lblContactInfo = new System.Windows.Forms.Label();
            this.txtboxNewPassword = new System.Windows.Forms.TextBox();
            this.lblSName = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.prgbrPasswordChanger = new System.Windows.Forms.ProgressBar();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.edusistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.BackColor = System.Drawing.Color.Transparent;
            this.lblCourses.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourses.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCourses.Location = new System.Drawing.Point(12, 81);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(68, 18);
            this.lblCourses.TabIndex = 1;
            this.lblCourses.Text = "Courses";
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.BackColor = System.Drawing.Color.Transparent;
            this.lblMark.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMark.Location = new System.Drawing.Point(186, 81);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(51, 18);
            this.lblMark.TabIndex = 2;
            this.lblMark.Text = "Marks";
            // 
            // lstboxCourses
            // 
            this.lstboxCourses.FormattingEnabled = true;
            this.lstboxCourses.Location = new System.Drawing.Point(12, 111);
            this.lstboxCourses.Name = "lstboxCourses";
            this.lstboxCourses.Size = new System.Drawing.Size(149, 121);
            this.lstboxCourses.TabIndex = 3;
            this.lstboxCourses.SelectedIndexChanged += new System.EventHandler(this.lstboxCourses_SelectedIndexChanged);
            // 
            // lblMarkDisplay
            // 
            this.lblMarkDisplay.AutoSize = true;
            this.lblMarkDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblMarkDisplay.Location = new System.Drawing.Point(176, 116);
            this.lblMarkDisplay.Name = "lblMarkDisplay";
            this.lblMarkDisplay.Size = new System.Drawing.Size(75, 13);
            this.lblMarkDisplay.TabIndex = 4;
            this.lblMarkDisplay.Text = "lblMarkDisplay";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(167, 183);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(112, 23);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Want to Change Your Password?";
            // 
            // lblContactTeacher
            // 
            this.lblContactTeacher.AutoSize = true;
            this.lblContactTeacher.BackColor = System.Drawing.Color.Transparent;
            this.lblContactTeacher.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactTeacher.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblContactTeacher.Location = new System.Drawing.Point(305, 81);
            this.lblContactTeacher.Name = "lblContactTeacher";
            this.lblContactTeacher.Size = new System.Drawing.Size(125, 18);
            this.lblContactTeacher.TabIndex = 7;
            this.lblContactTeacher.Text = "Contact Teacher";
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.AutoSize = true;
            this.lblContactInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblContactInfo.Location = new System.Drawing.Point(305, 116);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(102, 13);
            this.lblContactInfo.TabIndex = 8;
            this.lblContactInfo.Text = "TeacherContactInfo";
            // 
            // txtboxNewPassword
            // 
            this.txtboxNewPassword.Location = new System.Drawing.Point(231, 212);
            this.txtboxNewPassword.Name = "txtboxNewPassword";
            this.txtboxNewPassword.Size = new System.Drawing.Size(145, 20);
            this.txtboxNewPassword.TabIndex = 9;
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.BackColor = System.Drawing.Color.Transparent;
            this.lblSName.Location = new System.Drawing.Point(292, 31);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(70, 13);
            this.lblSName.TabIndex = 10;
            this.lblSName.Text = "studentName";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.BackColor = System.Drawing.Color.Transparent;
            this.lblGrade.Location = new System.Drawing.Point(292, 53);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(71, 13);
            this.lblGrade.TabIndex = 11;
            this.lblGrade.Text = "studentGrade";
            // 
            // prgbrPasswordChanger
            // 
            this.prgbrPasswordChanger.Location = new System.Drawing.Point(12, 239);
            this.prgbrPasswordChanger.Name = "prgbrPasswordChanger";
            this.prgbrPasswordChanger.Size = new System.Drawing.Size(367, 23);
            this.prgbrPasswordChanger.TabIndex = 12;
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.ForestGreen;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edusistToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(481, 24);
            this.mnuMain.TabIndex = 30;
            this.mnuMain.Text = "mnuMain";
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
            // frmStudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RattlerManagement.Properties.Resources.studentspanel;
            this.ClientSize = new System.Drawing.Size(481, 269);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.prgbrPasswordChanger);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblSName);
            this.Controls.Add(this.txtboxNewPassword);
            this.Controls.Add(this.lblContactInfo);
            this.Controls.Add(this.lblContactTeacher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblMarkDisplay);
            this.Controls.Add(this.lstboxCourses);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.lblCourses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmStudentProfile";
            this.Text = "Edusist: Student Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStudentProfile_FormClosing);
            this.Load += new System.EventHandler(this.frmStudentProfile_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.ListBox lstboxCourses;
        private System.Windows.Forms.Label lblMarkDisplay;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContactTeacher;
        private System.Windows.Forms.Label lblContactInfo;
        private System.Windows.Forms.TextBox txtboxNewPassword;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ProgressBar prgbrPasswordChanger;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem edusistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}