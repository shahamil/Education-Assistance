namespace RattlerManagement
{
    partial class frmTeacherProfile
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
            this.btn_EquipRental = new System.Windows.Forms.Button();
            this.lbl_tID = new System.Windows.Forms.Label();
            this.lbl_tName = new System.Windows.Forms.Label();
            this.btn_EmailTool = new System.Windows.Forms.Button();
            this.lsb_Courses = new System.Windows.Forms.ListBox();
            this.btn_ManageCourse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.edusistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_EquipRental
            // 
            this.btn_EquipRental.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_EquipRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EquipRental.ForeColor = System.Drawing.Color.White;
            this.btn_EquipRental.Location = new System.Drawing.Point(14, 162);
            this.btn_EquipRental.Name = "btn_EquipRental";
            this.btn_EquipRental.Size = new System.Drawing.Size(196, 32);
            this.btn_EquipRental.TabIndex = 0;
            this.btn_EquipRental.Text = "Equipment Rental";
            this.btn_EquipRental.UseVisualStyleBackColor = false;
            this.btn_EquipRental.Click += new System.EventHandler(this.btn_EquipRental_Click);
            // 
            // lbl_tID
            // 
            this.lbl_tID.AutoSize = true;
            this.lbl_tID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tID.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_tID.Location = new System.Drawing.Point(12, 96);
            this.lbl_tID.Name = "lbl_tID";
            this.lbl_tID.Size = new System.Drawing.Size(85, 14);
            this.lbl_tID.TabIndex = 3;
            this.lbl_tID.Text = "Teacher ID:";
            // 
            // lbl_tName
            // 
            this.lbl_tName.AutoSize = true;
            this.lbl_tName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tName.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_tName.Location = new System.Drawing.Point(12, 126);
            this.lbl_tName.Name = "lbl_tName";
            this.lbl_tName.Size = new System.Drawing.Size(105, 14);
            this.lbl_tName.TabIndex = 4;
            this.lbl_tName.Text = "Teacher name:";
            // 
            // btn_EmailTool
            // 
            this.btn_EmailTool.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_EmailTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EmailTool.ForeColor = System.Drawing.Color.White;
            this.btn_EmailTool.Location = new System.Drawing.Point(14, 195);
            this.btn_EmailTool.Name = "btn_EmailTool";
            this.btn_EmailTool.Size = new System.Drawing.Size(196, 30);
            this.btn_EmailTool.TabIndex = 5;
            this.btn_EmailTool.Text = "Email ";
            this.btn_EmailTool.UseVisualStyleBackColor = false;
            this.btn_EmailTool.Click += new System.EventHandler(this.btn_EmailTool_Click);
            // 
            // lsb_Courses
            // 
            this.lsb_Courses.FormattingEnabled = true;
            this.lsb_Courses.Location = new System.Drawing.Point(231, 106);
            this.lsb_Courses.Name = "lsb_Courses";
            this.lsb_Courses.Size = new System.Drawing.Size(146, 160);
            this.lsb_Courses.TabIndex = 6;
            // 
            // btn_ManageCourse
            // 
            this.btn_ManageCourse.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_ManageCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageCourse.ForeColor = System.Drawing.Color.White;
            this.btn_ManageCourse.Location = new System.Drawing.Point(15, 228);
            this.btn_ManageCourse.Name = "btn_ManageCourse";
            this.btn_ManageCourse.Size = new System.Drawing.Size(195, 29);
            this.btn_ManageCourse.TabIndex = 7;
            this.btn_ManageCourse.Text = "Go To Courses";
            this.btn_ManageCourse.UseVisualStyleBackColor = false;
            this.btn_ManageCourse.Click += new System.EventHandler(this.btnManageCourse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(271, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Courses";
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.ForestGreen;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edusistToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(498, 24);
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
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.howToUseToolStripMenuItem.Text = "How To Use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click_1);
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // frmTeacherProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RattlerManagement.Properties.Resources.teacherspanel;
            this.ClientSize = new System.Drawing.Size(498, 278);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ManageCourse);
            this.Controls.Add(this.lsb_Courses);
            this.Controls.Add(this.btn_EmailTool);
            this.Controls.Add(this.lbl_tName);
            this.Controls.Add(this.lbl_tID);
            this.Controls.Add(this.btn_EquipRental);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmTeacherProfile";
            this.Text = "Edusist: Teacher Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTeacherProfile_FormClosing);
            this.Load += new System.EventHandler(this.frmTeacherProfile_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EquipRental;
        private System.Windows.Forms.Label lbl_tID;
        private System.Windows.Forms.Label lbl_tName;
        private System.Windows.Forms.Button btn_EmailTool;
        private System.Windows.Forms.ListBox lsb_Courses;
        private System.Windows.Forms.Button btn_ManageCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem edusistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}