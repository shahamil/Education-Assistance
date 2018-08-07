namespace RattlerManagement
{
    partial class frmPrincipalPanel
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
            this.bttn_Go = new System.Windows.Forms.Button();
            this.rdb_CreateTeacher = new System.Windows.Forms.RadioButton();
            this.rdb_CreateStudent = new System.Windows.Forms.RadioButton();
            this.rdb_NewObject = new System.Windows.Forms.RadioButton();
            this.rdb_NewCourse = new System.Windows.Forms.RadioButton();
            this.rdb_FireTeacher = new System.Windows.Forms.RadioButton();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.edusistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttn_Go
            // 
            this.bttn_Go.BackColor = System.Drawing.Color.ForestGreen;
            this.bttn_Go.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Go.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttn_Go.Location = new System.Drawing.Point(12, 177);
            this.bttn_Go.Name = "bttn_Go";
            this.bttn_Go.Size = new System.Drawing.Size(197, 23);
            this.bttn_Go.TabIndex = 0;
            this.bttn_Go.Text = "GO";
            this.bttn_Go.UseVisualStyleBackColor = false;
            this.bttn_Go.Click += new System.EventHandler(this.bttn_Go_Click);
            // 
            // rdb_CreateTeacher
            // 
            this.rdb_CreateTeacher.AutoSize = true;
            this.rdb_CreateTeacher.BackColor = System.Drawing.Color.Transparent;
            this.rdb_CreateTeacher.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_CreateTeacher.Location = new System.Drawing.Point(12, 42);
            this.rdb_CreateTeacher.Name = "rdb_CreateTeacher";
            this.rdb_CreateTeacher.Size = new System.Drawing.Size(197, 22);
            this.rdb_CreateTeacher.TabIndex = 1;
            this.rdb_CreateTeacher.TabStop = true;
            this.rdb_CreateTeacher.Text = "Create New Teacher ";
            this.rdb_CreateTeacher.UseVisualStyleBackColor = false;
            // 
            // rdb_CreateStudent
            // 
            this.rdb_CreateStudent.AutoSize = true;
            this.rdb_CreateStudent.BackColor = System.Drawing.Color.Transparent;
            this.rdb_CreateStudent.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_CreateStudent.Location = new System.Drawing.Point(12, 67);
            this.rdb_CreateStudent.Name = "rdb_CreateStudent";
            this.rdb_CreateStudent.Size = new System.Drawing.Size(191, 22);
            this.rdb_CreateStudent.TabIndex = 2;
            this.rdb_CreateStudent.TabStop = true;
            this.rdb_CreateStudent.Text = "Create New Student";
            this.rdb_CreateStudent.UseVisualStyleBackColor = false;
            // 
            // rdb_NewObject
            // 
            this.rdb_NewObject.AutoSize = true;
            this.rdb_NewObject.BackColor = System.Drawing.Color.Transparent;
            this.rdb_NewObject.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_NewObject.Location = new System.Drawing.Point(12, 93);
            this.rdb_NewObject.Name = "rdb_NewObject";
            this.rdb_NewObject.Size = new System.Drawing.Size(181, 22);
            this.rdb_NewObject.TabIndex = 3;
            this.rdb_NewObject.TabStop = true;
            this.rdb_NewObject.Text = "Create New Object";
            this.rdb_NewObject.UseVisualStyleBackColor = false;
            // 
            // rdb_NewCourse
            // 
            this.rdb_NewCourse.AutoSize = true;
            this.rdb_NewCourse.BackColor = System.Drawing.Color.Transparent;
            this.rdb_NewCourse.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_NewCourse.Location = new System.Drawing.Point(12, 117);
            this.rdb_NewCourse.Name = "rdb_NewCourse";
            this.rdb_NewCourse.Size = new System.Drawing.Size(189, 22);
            this.rdb_NewCourse.TabIndex = 4;
            this.rdb_NewCourse.TabStop = true;
            this.rdb_NewCourse.Text = "Create New Course ";
            this.rdb_NewCourse.UseVisualStyleBackColor = false;
            // 
            // rdb_FireTeacher
            // 
            this.rdb_FireTeacher.AutoSize = true;
            this.rdb_FireTeacher.BackColor = System.Drawing.Color.Transparent;
            this.rdb_FireTeacher.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_FireTeacher.Location = new System.Drawing.Point(12, 140);
            this.rdb_FireTeacher.Name = "rdb_FireTeacher";
            this.rdb_FireTeacher.Size = new System.Drawing.Size(142, 22);
            this.rdb_FireTeacher.TabIndex = 5;
            this.rdb_FireTeacher.TabStop = true;
            this.rdb_FireTeacher.Text = "Fire a Teacher";
            this.rdb_FireTeacher.UseVisualStyleBackColor = false;
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.ForestGreen;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edusistToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(248, 24);
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
            // frmPrincipalPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RattlerManagement.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(248, 226);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.rdb_FireTeacher);
            this.Controls.Add(this.rdb_NewCourse);
            this.Controls.Add(this.rdb_NewObject);
            this.Controls.Add(this.rdb_CreateStudent);
            this.Controls.Add(this.rdb_CreateTeacher);
            this.Controls.Add(this.bttn_Go);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPrincipalPanel";
            this.Text = "Edusist: Principal Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipalPanel_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipalPanel_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_Go;
        private System.Windows.Forms.RadioButton rdb_CreateTeacher;
        private System.Windows.Forms.RadioButton rdb_CreateStudent;
        private System.Windows.Forms.RadioButton rdb_NewObject;
        private System.Windows.Forms.RadioButton rdb_NewCourse;
        private System.Windows.Forms.RadioButton rdb_FireTeacher;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem edusistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

