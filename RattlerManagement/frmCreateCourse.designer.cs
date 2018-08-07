namespace RattlerManagement
{
    partial class frmCreateCourse
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
            this.bttn_CreateNewCourse = new System.Windows.Forms.Button();
            this.txt_cID = new System.Windows.Forms.TextBox();
            this.txt_cCode = new System.Windows.Forms.TextBox();
            this.txt_cTeacher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cKU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cAp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cTI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cComm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cCulm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cExam = new System.Windows.Forms.TextBox();
            this.lblCourseRoom = new System.Windows.Forms.Label();
            this.txt_CourseRoom = new System.Windows.Forms.TextBox();
            this.btnCourseEdit = new System.Windows.Forms.Button();
            this.prgCourseSaver = new System.Windows.Forms.ProgressBar();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.edusistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttn_CreateNewCourse
            // 
            this.bttn_CreateNewCourse.BackColor = System.Drawing.Color.ForestGreen;
            this.bttn_CreateNewCourse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_CreateNewCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttn_CreateNewCourse.Location = new System.Drawing.Point(128, 162);
            this.bttn_CreateNewCourse.Name = "bttn_CreateNewCourse";
            this.bttn_CreateNewCourse.Size = new System.Drawing.Size(217, 41);
            this.bttn_CreateNewCourse.TabIndex = 0;
            this.bttn_CreateNewCourse.Text = "Create New Course";
            this.bttn_CreateNewCourse.UseVisualStyleBackColor = false;
            this.bttn_CreateNewCourse.Click += new System.EventHandler(this.bttn_CreateNewCourse_Click);
            // 
            // txt_cID
            // 
            this.txt_cID.Location = new System.Drawing.Point(9, 41);
            this.txt_cID.Name = "txt_cID";
            this.txt_cID.Size = new System.Drawing.Size(100, 20);
            this.txt_cID.TabIndex = 1;
            this.txt_cID.TextChanged += new System.EventHandler(this.txt_cID_TextChanged);
            // 
            // txt_cCode
            // 
            this.txt_cCode.Location = new System.Drawing.Point(8, 179);
            this.txt_cCode.Name = "txt_cCode";
            this.txt_cCode.Size = new System.Drawing.Size(100, 20);
            this.txt_cCode.TabIndex = 3;
            this.txt_cCode.TextChanged += new System.EventHandler(this.txt_cCode_TextChanged);
            // 
            // txt_cTeacher
            // 
            this.txt_cTeacher.Location = new System.Drawing.Point(8, 90);
            this.txt_cTeacher.Name = "txt_cTeacher";
            this.txt_cTeacher.Size = new System.Drawing.Size(100, 20);
            this.txt_cTeacher.TabIndex = 4;
            this.txt_cTeacher.TextChanged += new System.EventHandler(this.txt_cTeacher_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Course ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(5, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Course Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(5, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Course Teacher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(125, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Course K/U";
            // 
            // txt_cKU
            // 
            this.txt_cKU.Location = new System.Drawing.Point(128, 46);
            this.txt_cKU.Name = "txt_cKU";
            this.txt_cKU.Size = new System.Drawing.Size(100, 20);
            this.txt_cKU.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(242, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Course Application";
            // 
            // txt_cAp
            // 
            this.txt_cAp.Location = new System.Drawing.Point(245, 46);
            this.txt_cAp.Name = "txt_cAp";
            this.txt_cAp.Size = new System.Drawing.Size(100, 20);
            this.txt_cAp.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(242, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Course T/I";
            // 
            // txt_cTI
            // 
            this.txt_cTI.Location = new System.Drawing.Point(245, 90);
            this.txt_cTI.Name = "txt_cTI";
            this.txt_cTI.Size = new System.Drawing.Size(100, 20);
            this.txt_cTI.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(125, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Course Communication";
            // 
            // txt_cComm
            // 
            this.txt_cComm.Location = new System.Drawing.Point(128, 90);
            this.txt_cComm.Name = "txt_cComm";
            this.txt_cComm.Size = new System.Drawing.Size(100, 20);
            this.txt_cComm.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(125, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Course Culminating";
            // 
            // txt_cCulm
            // 
            this.txt_cCulm.Location = new System.Drawing.Point(128, 136);
            this.txt_cCulm.Name = "txt_cCulm";
            this.txt_cCulm.Size = new System.Drawing.Size(100, 20);
            this.txt_cCulm.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(242, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Course Exams";
            // 
            // txt_cExam
            // 
            this.txt_cExam.Location = new System.Drawing.Point(245, 136);
            this.txt_cExam.Name = "txt_cExam";
            this.txt_cExam.Size = new System.Drawing.Size(100, 20);
            this.txt_cExam.TabIndex = 19;
            // 
            // lblCourseRoom
            // 
            this.lblCourseRoom.AutoSize = true;
            this.lblCourseRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseRoom.Location = new System.Drawing.Point(5, 119);
            this.lblCourseRoom.Name = "lblCourseRoom";
            this.lblCourseRoom.Size = new System.Drawing.Size(71, 13);
            this.lblCourseRoom.TabIndex = 22;
            this.lblCourseRoom.Text = "Course Room";
            // 
            // txt_CourseRoom
            // 
            this.txt_CourseRoom.Location = new System.Drawing.Point(8, 136);
            this.txt_CourseRoom.Name = "txt_CourseRoom";
            this.txt_CourseRoom.Size = new System.Drawing.Size(100, 20);
            this.txt_CourseRoom.TabIndex = 21;
            // 
            // btnCourseEdit
            // 
            this.btnCourseEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCourseEdit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCourseEdit.Location = new System.Drawing.Point(57, 256);
            this.btnCourseEdit.Name = "btnCourseEdit";
            this.btnCourseEdit.Size = new System.Drawing.Size(342, 45);
            this.btnCourseEdit.TabIndex = 23;
            this.btnCourseEdit.Text = "Course Enrollment Manager";
            this.btnCourseEdit.UseVisualStyleBackColor = false;
            this.btnCourseEdit.Click += new System.EventHandler(this.btnCourseEdit_Click);
            // 
            // prgCourseSaver
            // 
            this.prgCourseSaver.Location = new System.Drawing.Point(10, 222);
            this.prgCourseSaver.Maximum = 10;
            this.prgCourseSaver.Name = "prgCourseSaver";
            this.prgCourseSaver.Size = new System.Drawing.Size(427, 25);
            this.prgCourseSaver.TabIndex = 30;
            this.prgCourseSaver.Value = 10;
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.ForestGreen;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edusistToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(466, 24);
            this.mnuMain.TabIndex = 31;
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
            // frmCreateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RattlerManagement.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(466, 313);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.prgCourseSaver);
            this.Controls.Add(this.btnCourseEdit);
            this.Controls.Add(this.lblCourseRoom);
            this.Controls.Add(this.txt_CourseRoom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_cExam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_cCulm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_cComm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cTI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_cAp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cKU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cTeacher);
            this.Controls.Add(this.txt_cCode);
            this.Controls.Add(this.txt_cID);
            this.Controls.Add(this.bttn_CreateNewCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCreateCourse";
            this.Text = "Edusist: Create New Course";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCreateCourse_FormClosing);
            this.Load += new System.EventHandler(this.frmCreateCourse_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_CreateNewCourse;
        private System.Windows.Forms.TextBox txt_cID;
        private System.Windows.Forms.TextBox txt_cCode;
        private System.Windows.Forms.TextBox txt_cTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cKU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cAp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cTI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cComm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cCulm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cExam;
        private System.Windows.Forms.Label lblCourseRoom;
        private System.Windows.Forms.TextBox txt_CourseRoom;
        private System.Windows.Forms.Button btnCourseEdit;
        private System.Windows.Forms.ProgressBar prgCourseSaver;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem edusistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}