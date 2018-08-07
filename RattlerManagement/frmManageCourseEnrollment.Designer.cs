namespace RattlerManagement
{
    partial class frmManageCourseEnrollment
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
            this.lsboxStudentNames = new System.Windows.Forms.ListBox();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnLoadCourse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.edusistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsboxStudentNames
            // 
            this.lsboxStudentNames.FormattingEnabled = true;
            this.lsboxStudentNames.Location = new System.Drawing.Point(162, 40);
            this.lsboxStudentNames.Name = "lsboxStudentNames";
            this.lsboxStudentNames.Size = new System.Drawing.Size(127, 108);
            this.lsboxStudentNames.TabIndex = 0;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(12, 45);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(129, 20);
            this.txtCourseID.TabIndex = 2;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentID.Location = new System.Drawing.Point(12, 113);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(58, 13);
            this.lblStudentID.TabIndex = 3;
            this.lblStudentID.Text = "Student ID";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Location = new System.Drawing.Point(12, 152);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(129, 23);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnEnrolStudent_Click);
            // 
            // btnLoadCourse
            // 
            this.btnLoadCourse.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLoadCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadCourse.ForeColor = System.Drawing.Color.White;
            this.btnLoadCourse.Location = new System.Drawing.Point(12, 71);
            this.btnLoadCourse.Name = "btnLoadCourse";
            this.btnLoadCourse.Size = new System.Drawing.Size(129, 23);
            this.btnLoadCourse.TabIndex = 8;
            this.btnLoadCourse.Text = "Load Course";
            this.btnLoadCourse.UseVisualStyleBackColor = false;
            this.btnLoadCourse.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Course ID";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(12, 129);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(129, 20);
            this.txtStudentID.TabIndex = 6;
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRemoveStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStudent.ForeColor = System.Drawing.Color.White;
            this.btnRemoveStudent.Location = new System.Drawing.Point(162, 152);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(129, 23);
            this.btnRemoveStudent.TabIndex = 11;
            this.btnRemoveStudent.Text = "Remove Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = false;
            this.btnRemoveStudent.Click += new System.EventHandler(this.button2_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.ForestGreen;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edusistToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(314, 24);
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
            // frmManageCourseEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RattlerManagement.Properties.Resources._735420;
            this.ClientSize = new System.Drawing.Size(314, 184);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnLoadCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.lsboxStudentNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmManageCourseEnrollment";
            this.Text = "Manage CourseEnrollment";
            this.Load += new System.EventHandler(this.frmManageCourseEnrollment_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsboxStudentNames;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnLoadCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem edusistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}